using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.Media;

namespace Enrollment
{

	delegate void Function1();
	/* NOTE: This form is a base for the EnrollmentForm and the VerificationForm,
		All changes in the CaptureForm will be reflected in all its derived forms.
	*/
	public partial class CaptureForm : Form, DPFP.Capture.EventHandler


	{
		SoundPlayer ReproductoWav;

		public CaptureForm()
		{

			InitializeComponent();
			ReproductoWav = new SoundPlayer();
		}

		[DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
		private static extern int Grabar(string Comando, string StringRetono, int Longitud, int hwndCallback);
		private void btnGrabar_Click(object sender, EventArgs e)
		{
			
		}


		FilterInfoCollection filterInfoCollection;
		VideoCaptureDevice videoCaptureDevice;

		protected virtual void Init()
		{
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if ( null != Capturer )
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {               
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
		}

		protected virtual void Process(DPFP.Sample Sample)
		{
			// Draw fingerprint sample image.
			DrawPicture(ConvertSampleToBitmap(Sample));
		}

		protected void Start()
		{
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
		}

		protected void Stop()
		{
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
		}
		
	#region Form Event Handlers:

		private void CaptureForm_Load(object sender, EventArgs e)
		{
				//Init();
				//Start();                                                // Start capture operation.


				filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
				foreach (FilterInfo Device in filterInfoCollection)
					comboBox1.Items.Add(Device.Name);
				//comboBox1.SelectedIndex = 0;
				videoCaptureDevice = new VideoCaptureDevice();

				/*videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
				videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
				videoCaptureDevice.Start();*/
			

			//INICIALIZO GRABACION DE MICROFONO
			
			Grabar("open new Type waveaudio Alias recsound", "", 0, 0);
			Grabar("record recsound", "", 0, 0);

			btnGrabar.Image = Properties.Resources.Recordoff;
			Micro.Image = Properties.Resources.Micro;
			btnParar.Image = Properties.Resources.Stop;
			btnReproducir.Image = Properties.Resources.playoff;
			UrlReproductor.Text = "";
			ReproductoWav.Stop();

			//------

		}

		private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	#endregion

	#region EventHandler Members:

		public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
		{
			MakeReport("The fingerprint sample was captured.");
			SetPrompt("Scan the same fingerprint again.");
			Process(Sample);
		}

		public void OnFingerGone(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The finger was removed from the fingerprint reader.");
		}

		public void OnFingerTouch(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was touched.");
		}

		public void OnReaderConnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was connected.");
		}

		public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was disconnected.");
		}

		public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
		{
			if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
				MakeReport("The quality of the fingerprint sample is good.");
			else
				MakeReport("The quality of the fingerprint sample is poor.");
		}
	#endregion

		protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
		{
			DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
			Bitmap bitmap = null;												            // TODO: the size doesn't matter
			Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: return bitmap as a result
			return bitmap;
		}

		protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
		{
			DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
			DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
			DPFP.FeatureSet features = new DPFP.FeatureSet();
			Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
			if (feedback == DPFP.Capture.CaptureFeedback.Good)
				return features;
			else
				return null;
		}

		protected void SetStatus(string status)
		{
			this.Invoke(new Function(delegate() {
				StatusLine.Text = status;
			}));
		}

		protected void SetPrompt(string prompt)
		{
			this.Invoke(new Function(delegate() {
				Prompt.Text = prompt;
			}));
		}
		protected void MakeReport(string message)
		{
			this.Invoke(new Function(delegate() {
				StatusText.AppendText(message + "\r\n");
			}));
		}

		private void DrawPicture(Bitmap bitmap)
		{
			this.Invoke(new Function(delegate() {
				Picture.Image = new Bitmap(bitmap, Picture.Size);	// fit the image into the picture box
			}));
		}

		private DPFP.Capture.Capture Capturer;

        private void EnrollButton_Click(object sender, EventArgs e)
        {
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Fingerprint Template File (*.fpt)|*.fpt";
			if (save.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fs = File.Open(save.FileName, FileMode.Create, FileAccess.Write))
				{
					Template.Serialize(fs);
				}
			}


		}

        private void VerifyButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
		
		}

		private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (videoCaptureDevice.IsRunning == true)
				videoCaptureDevice.Stop();
		}

        private void StatusLine_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
		
		}

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

		private void OnTemplate(DPFP.Template template)
		{
			this.Invoke(new Function(delegate ()
			{
				Template = template;
				
				if (Template != null)
					MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
				else
					MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
			}));
		}

		private DPFP.Template Template;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
			
				int widthCamara = Convert.ToInt32(pictureBox1.Width);
				int heightCamara = Convert.ToInt32(pictureBox1.Height);
				int widthHuella = Convert.ToInt32(Picture.Width);
				int heightHuella = Convert.ToInt32(Picture.Height);
			
			var ruta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS";
			var contrato = numeroContrato.Text;
			var nombre= nombreUsuario.Text;
			var rutaFirma = ruta + @"\CTO_" + contrato + @"\FIRMA\" + nombre + ".jpg";
			var rutaHuella = ruta + @"\CTO_" + contrato + @"\HUELLA\" + nombre + ".jpg";
			textBox1.Text = rutaFirma;

			using (Bitmap bmp = new Bitmap(widthCamara, heightCamara))
				{
					pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, widthCamara, heightCamara));
					bmp.Save(rutaFirma);
				MessageBox.Show("Firma Guardada");
			
			}
			using (Bitmap bmp = new Bitmap(widthCamara, heightCamara))
			{
				Picture.DrawToBitmap(bmp, new Rectangle(0, 0, widthHuella, heightHuella));
				bmp.Save(rutaHuella);
				MessageBox.Show("Huella Guardada");

			}
			



		}

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			int widthHuella = Convert.ToInt32(Picture.Width);
			int heightHuella = Convert.ToInt32(Picture.Height);
			


			var ruta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS";
			var contrato = numeroContrato.Text;
			var nombre = nombreUsuario.Text;
			var rutaHuella = ruta + @"\CTO_" + contrato + @"\HUELLA\" + nombre + ".jpg";


			using (Bitmap bmp = new Bitmap(widthHuella, heightHuella))
			{
				Picture.DrawToBitmap(bmp, new Rectangle(0, 0, widthHuella, heightHuella));
				bmp.Save(rutaHuella);
			}

			
		}

        private void button2_Click_1(object sender, EventArgs e)
        {
			videoCaptureDevice.Stop();
			System.Windows.Forms.Application.Exit();
		
		}

        private void button4_Click(object sender, EventArgs e)
        {
			videoCaptureDevice.Stop();
			System.Windows.Forms.Application.Exit();





			//FINALIZO GRABACION DE MICROFONO----------------------------------

			Micro.Image = Properties.Resources.MicroOff;



			//VERIFICO SI DIRECTORIO EXISTE
			var rutaCarpeta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS\CTO_" + numeroContrato.Text + @"\" + @"AUDIO";

			if (!Directory.Exists(rutaCarpeta))
			{
				Console.WriteLine("Creando el directorio: {0}", rutaCarpeta);
				DirectoryInfo di = Directory.CreateDirectory(rutaCarpeta);
			}

			//--




			btnParar.Image = Properties.Resources.Stopoff;
			btnGrabar.Image = Properties.Resources.Record;
			btnReproducir.Image = Properties.Resources.play;

            if (numeroContrato.Text == "")
            {
				UrlReproductor.Text = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS\REUNIONES\REUNION-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm") + @".wav";
				Console.WriteLine(UrlReproductor.Text);

			}else { 
			
				
				UrlReproductor.Text = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS\CTO_" + numeroContrato.Text + @"\AUDIO\" + numeroContrato.Text + @"-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm") + ".wav";
			}
			Grabar("save recsound " + UrlReproductor.Text, "", 0, 0);
			Grabar("close recsound", "", 0, 0);

			//------TERMINO DE GRABAR ARCHIVO DE MICROFONO----------------------




		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

			int widthHuella = Convert.ToInt32(Picture.Width);
			int heightHuella = Convert.ToInt32(Picture.Height);
			


			var ruta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS";
			var contrato = numeroContrato.Text;
			var nombre = nombreUsuario.Text;
			
			var rutaHuella = ruta + @"\CTO_" + contrato + @"\HUELLA\" + nombre + " - SIN HUELLA.jpg";


			using (Bitmap bmp = new Bitmap(widthHuella, heightHuella))
			{
				pictureBox2.DrawToBitmap(bmp, new Rectangle(0, 0, widthHuella, heightHuella));
				bmp.Save(rutaHuella);
			}

			
		}

        private void button2_Click_2(object sender, EventArgs e)
        {
			int widthCamara = Convert.ToInt32(pictureBox1.Width);
			int heightCamara = Convert.ToInt32(pictureBox1.Height);
		

			var ruta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS";
			var contrato = numeroContrato.Text;
			var nombre = nombreUsuario.Text;
			var rutaFirma = ruta + @"\CTO_" + contrato + @"\FIRMA\" + nombre + ".jpg";
		
			textBox1.Text = rutaFirma;

			using (Bitmap bmp = new Bitmap(widthCamara, heightCamara))
			{
				pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, widthCamara, heightCamara));
				bmp.Save(rutaFirma);

			}
		
		}

        private void button6_Click(object sender, EventArgs e)
        {
			var rutaCarpeta = @"\\servidor1\Fotos\FOTOS_FIRMA_DE_CONTRATOS\CTO_"+ numeroContrato.Text;
			System.Diagnostics.Process.Start("explorer.exe", rutaCarpeta);

		}

       

        private void btnParar_Click(object sender, EventArgs e)
        {
			

			
		}

        private void btnReproducir_Click(object sender, EventArgs e)
        {
			ReproductoWav.SoundLocation = UrlReproductor.Text;
			ReproductoWav.Play();

		}

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			Micro.Visible = false;
			grabandoTXT.Visible= false;
			timer1.Enabled = false;
			timer2.Enabled = true;
			
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
			Micro.Visible=true;
			grabandoTXT.Visible = true;
			timer1.Enabled = true;
			timer2.Enabled = false;
        }
    }


}