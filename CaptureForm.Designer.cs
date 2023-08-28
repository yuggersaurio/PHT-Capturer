namespace Enrollment
{
	partial class CaptureForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label PromptLabel;
            System.Windows.Forms.Label StatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.Prompt = new System.Windows.Forms.TextBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.StatusLine = new System.Windows.Forms.Label();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numeroContrato = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UrlReproductor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Micro = new System.Windows.Forms.PictureBox();
            this.grabandoTXT = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.PictureBox();
            this.btnReproducir = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new System.Windows.Forms.PictureBox();
            PromptLabel = new System.Windows.Forms.Label();
            StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Micro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabar)).BeginInit();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.Location = new System.Drawing.Point(362, 656);
            PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new System.Drawing.Size(53, 16);
            PromptLabel.TabIndex = 1;
            PromptLabel.Text = "Prompt:";
            PromptLabel.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(725, 656);
            StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(47, 16);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            StatusLabel.Visible = false;
            // 
            // Prompt
            // 
            this.Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt.Location = new System.Drawing.Point(423, 656);
            this.Prompt.Margin = new System.Windows.Forms.Padding(4);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(258, 22);
            this.Prompt.TabIndex = 2;
            this.Prompt.Visible = false;
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(124, 686);
            this.StatusText.Margin = new System.Windows.Forms.Padding(4);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(368, 118);
            this.StatusText.TabIndex = 4;
            this.StatusText.Visible = false;
            // 
            // StatusLine
            // 
            this.StatusLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLine.Location = new System.Drawing.Point(14, 464);
            this.StatusLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(55, 27);
            this.StatusLine.TabIndex = 5;
            this.StatusLine.Text = "[Status line]";
            this.StatusLine.Visible = false;
            this.StatusLine.Click += new System.EventHandler(this.StatusLine_Click);
            // 
            // EnrollButton
            // 
            this.EnrollButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnrollButton.Location = new System.Drawing.Point(821, 646);
            this.EnrollButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(281, 31);
            this.EnrollButton.TabIndex = 7;
            this.EnrollButton.Text = "Fingerprint Enrollment";
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Visible = false;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(664, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // numeroContrato
            // 
            this.numeroContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroContrato.Location = new System.Drawing.Point(143, 31);
            this.numeroContrato.Name = "numeroContrato";
            this.numeroContrato.Size = new System.Drawing.Size(168, 30);
            this.numeroContrato.TabIndex = 17;
            this.numeroContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.Picture);
            this.groupBox1.Controls.Add(this.StatusLine);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 498);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Huella";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Enrollment.Properties.Resources.sin_huella1;
            this.pictureBox2.Location = new System.Drawing.Point(345, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 464);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(17, 22);
            this.Picture.Margin = new System.Windows.Forms.Padding(4);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(310, 464);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 498);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 464);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Número de contrato";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nombreUsuario);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numeroContrato);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1039, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 125);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del usuario";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(143, 80);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(168, 27);
            this.nombreUsuario.TabIndex = 22;
            this.nombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre de usuario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(1039, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 496);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Enrollment.Properties.Resources.openfolder_icon___copia;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(11, 335);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button6.Size = new System.Drawing.Size(305, 74);
            this.button6.TabIndex = 27;
            this.button6.Text = "Verificar carpeta de contrato";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = global::Enrollment.Properties.Resources.sin_huella;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(10, 255);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(305, 74);
            this.button5.TabIndex = 26;
            this.button5.Text = "No se puede registrar huella";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Enrollment.Properties.Resources.camara;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 175);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(305, 74);
            this.button2.TabIndex = 25;
            this.button2.Text = "Guardar unicamente foto";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button4
            // 
            this.button4.Image = global::Enrollment.Properties.Resources.exit;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 414);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(305, 74);
            this.button4.TabIndex = 25;
            this.button4.Text = "Salir de PHTools Capture";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Enrollment.Properties.Resources.huella;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 94);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(305, 74);
            this.button1.TabIndex = 24;
            this.button1.Text = "Guardar unicamente huella";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Image = global::Enrollment.Properties.Resources.save__Personalizado_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 14);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(305, 74);
            this.button3.TabIndex = 16;
            this.button3.Text = "Guardar huella y foto";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(631, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Digite el número de contrato y el usuario para almacenar el registro fotografico " +
    "y dactilar, para guardar presione el botón Guardar huella y foto.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(622, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Para guardar una foto de forma individual presione Guardar unicamente foto.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(622, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Para guardar una huella de forma individual presione Guardar unicamente huella.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(622, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Si no es posible realizar el registro dactilar presione el botón No se puede regi" +
    "strar Huella.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(377, 517);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(645, 122);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            // 
            // UrlReproductor
            // 
            this.UrlReproductor.AutoSize = true;
            this.UrlReproductor.Location = new System.Drawing.Point(289, 550);
            this.UrlReproductor.Name = "UrlReproductor";
            this.UrlReproductor.Size = new System.Drawing.Size(0, 16);
            this.UrlReproductor.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Micro
            // 
            this.Micro.BackColor = System.Drawing.SystemColors.Control;
            this.Micro.Image = global::Enrollment.Properties.Resources.Micro;
            this.Micro.Location = new System.Drawing.Point(130, 523);
            this.Micro.Name = "Micro";
            this.Micro.Size = new System.Drawing.Size(95, 88);
            this.Micro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Micro.TabIndex = 32;
            this.Micro.TabStop = false;
            // 
            // grabandoTXT
            // 
            this.grabandoTXT.AutoSize = true;
            this.grabandoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabandoTXT.ForeColor = System.Drawing.Color.Red;
            this.grabandoTXT.Location = new System.Drawing.Point(108, 621);
            this.grabandoTXT.Name = "grabandoTXT";
            this.grabandoTXT.Size = new System.Drawing.Size(143, 16);
            this.grabandoTXT.TabIndex = 36;
            this.grabandoTXT.Text = "Grabando reunion...";
            this.grabandoTXT.Visible = false;
            // 
            // btnParar
            // 
            this.btnParar.Image = global::Enrollment.Properties.Resources.Stopoff;
            this.btnParar.Location = new System.Drawing.Point(272, 614);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(31, 31);
            this.btnParar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnParar.TabIndex = 34;
            this.btnParar.TabStop = false;
            this.btnParar.Visible = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Image = global::Enrollment.Properties.Resources.playoff;
            this.btnReproducir.Location = new System.Drawing.Point(309, 614);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(31, 31);
            this.btnReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReproducir.TabIndex = 35;
            this.btnReproducir.TabStop = false;
            this.btnReproducir.Visible = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::Enrollment.Properties.Resources.Record;
            this.btnGrabar.Location = new System.Drawing.Point(235, 614);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(31, 31);
            this.btnGrabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGrabar.TabIndex = 33;
            this.btnGrabar.TabStop = false;
            this.btnGrabar.Visible = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 692);
            this.ControlBox = false;
            this.Controls.Add(this.Micro);
            this.Controls.Add(this.grabandoTXT);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.UrlReproductor);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnrollButton);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(StatusLabel);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(PromptLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 358);
            this.Name = "CaptureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHTools Capture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Micro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGrabar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Picture;
		private System.Windows.Forms.TextBox Prompt;
		private System.Windows.Forms.TextBox StatusText;
		private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox numeroContrato;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox Micro;
        private System.Windows.Forms.Label UrlReproductor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label grabandoTXT;
        private System.Windows.Forms.PictureBox btnParar;
        private System.Windows.Forms.PictureBox btnReproducir;
        private System.Windows.Forms.PictureBox btnGrabar;
    }
}