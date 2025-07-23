namespace JigaSoftware
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bxPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.requestReadsTimer = new System.Windows.Forms.Timer(this.components);
            this.txtVoltage0 = new System.Windows.Forms.TextBox();
            this.txtVoltage1 = new System.Windows.Forms.TextBox();
            this.txtVoltage2 = new System.Windows.Forms.TextBox();
            this.txtVoltage9 = new System.Windows.Forms.TextBox();
            this.txtVoltage3 = new System.Windows.Forms.TextBox();
            this.txtVoltage4 = new System.Windows.Forms.TextBox();
            this.txtVoltage5 = new System.Windows.Forms.TextBox();
            this.txtVoltage6 = new System.Windows.Forms.TextBox();
            this.txtVoltage7 = new System.Windows.Forms.TextBox();
            this.txtVoltage8 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrent8 = new System.Windows.Forms.TextBox();
            this.txtCurrent0 = new System.Windows.Forms.TextBox();
            this.txtCurrent7 = new System.Windows.Forms.TextBox();
            this.txtCurrent1 = new System.Windows.Forms.TextBox();
            this.txtCurrent6 = new System.Windows.Forms.TextBox();
            this.txtCurrent2 = new System.Windows.Forms.TextBox();
            this.txtCurrent5 = new System.Windows.Forms.TextBox();
            this.txtCurrent9 = new System.Windows.Forms.TextBox();
            this.txtCurrent4 = new System.Windows.Forms.TextBox();
            this.txtCurrent3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.BaudRate = 115200;
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialDataReceivedHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bxPort);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnRefreshPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port";
            // 
            // bxPort
            // 
            this.bxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bxPort.FormattingEnabled = true;
            this.bxPort.Location = new System.Drawing.Point(84, 21);
            this.bxPort.Name = "bxPort";
            this.bxPort.Size = new System.Drawing.Size(121, 21);
            this.bxPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(302, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(221, 21);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPorts.TabIndex = 0;
            this.btnRefreshPorts.Text = "Refresh";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMessageBox.Location = new System.Drawing.Point(6, 14);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBox.Size = new System.Drawing.Size(509, 113);
            this.txtMessageBox.TabIndex = 1;
            // 
            // requestReadsTimer
            // 
            this.requestReadsTimer.Enabled = true;
            this.requestReadsTimer.Interval = 1000;
            this.requestReadsTimer.Tick += new System.EventHandler(this.requestReadsTimer_Tick);
            // 
            // txtVoltage0
            // 
            this.txtVoltage0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage0.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage0.Location = new System.Drawing.Point(18, 94);
            this.txtVoltage0.Name = "txtVoltage0";
            this.txtVoltage0.ReadOnly = true;
            this.txtVoltage0.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage0.TabIndex = 9;
            // 
            // txtVoltage1
            // 
            this.txtVoltage1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage1.Location = new System.Drawing.Point(110, 94);
            this.txtVoltage1.Name = "txtVoltage1";
            this.txtVoltage1.ReadOnly = true;
            this.txtVoltage1.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage1.TabIndex = 10;
            // 
            // txtVoltage2
            // 
            this.txtVoltage2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage2.Location = new System.Drawing.Point(201, 94);
            this.txtVoltage2.Name = "txtVoltage2";
            this.txtVoltage2.ReadOnly = true;
            this.txtVoltage2.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage2.TabIndex = 11;
            // 
            // txtVoltage9
            // 
            this.txtVoltage9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage9.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage9.Location = new System.Drawing.Point(833, 94);
            this.txtVoltage9.Name = "txtVoltage9";
            this.txtVoltage9.ReadOnly = true;
            this.txtVoltage9.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage9.TabIndex = 12;
            // 
            // txtVoltage3
            // 
            this.txtVoltage3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage3.Location = new System.Drawing.Point(293, 94);
            this.txtVoltage3.Name = "txtVoltage3";
            this.txtVoltage3.ReadOnly = true;
            this.txtVoltage3.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage3.TabIndex = 13;
            // 
            // txtVoltage4
            // 
            this.txtVoltage4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage4.Location = new System.Drawing.Point(383, 94);
            this.txtVoltage4.Name = "txtVoltage4";
            this.txtVoltage4.ReadOnly = true;
            this.txtVoltage4.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage4.TabIndex = 14;
            // 
            // txtVoltage5
            // 
            this.txtVoltage5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage5.Location = new System.Drawing.Point(473, 94);
            this.txtVoltage5.Name = "txtVoltage5";
            this.txtVoltage5.ReadOnly = true;
            this.txtVoltage5.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage5.TabIndex = 15;
            // 
            // txtVoltage6
            // 
            this.txtVoltage6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage6.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage6.Location = new System.Drawing.Point(563, 94);
            this.txtVoltage6.Name = "txtVoltage6";
            this.txtVoltage6.ReadOnly = true;
            this.txtVoltage6.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage6.TabIndex = 16;
            // 
            // txtVoltage7
            // 
            this.txtVoltage7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage7.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage7.Location = new System.Drawing.Point(653, 94);
            this.txtVoltage7.Name = "txtVoltage7";
            this.txtVoltage7.ReadOnly = true;
            this.txtVoltage7.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage7.TabIndex = 17;
            // 
            // txtVoltage8
            // 
            this.txtVoltage8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage8.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage8.Location = new System.Drawing.Point(743, 94);
            this.txtVoltage8.Name = "txtVoltage8";
            this.txtVoltage8.ReadOnly = true;
            this.txtVoltage8.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage8.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button29);
            this.groupBox2.Controls.Add(this.button30);
            this.groupBox2.Controls.Add(this.button31);
            this.groupBox2.Controls.Add(this.button32);
            this.groupBox2.Controls.Add(this.button33);
            this.groupBox2.Controls.Add(this.button34);
            this.groupBox2.Controls.Add(this.button35);
            this.groupBox2.Controls.Add(this.button36);
            this.groupBox2.Controls.Add(this.button37);
            this.groupBox2.Controls.Add(this.button38);
            this.groupBox2.Controls.Add(this.button39);
            this.groupBox2.Controls.Add(this.button40);
            this.groupBox2.Controls.Add(this.button41);
            this.groupBox2.Controls.Add(this.button42);
            this.groupBox2.Controls.Add(this.button43);
            this.groupBox2.Controls.Add(this.button44);
            this.groupBox2.Controls.Add(this.button45);
            this.groupBox2.Controls.Add(this.button46);
            this.groupBox2.Controls.Add(this.button47);
            this.groupBox2.Controls.Add(this.button48);
            this.groupBox2.Controls.Add(this.button27);
            this.groupBox2.Controls.Add(this.button28);
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.button26);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.button24);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCurrent8);
            this.groupBox2.Controls.Add(this.txtCurrent0);
            this.groupBox2.Controls.Add(this.txtCurrent7);
            this.groupBox2.Controls.Add(this.txtCurrent1);
            this.groupBox2.Controls.Add(this.txtCurrent6);
            this.groupBox2.Controls.Add(this.txtCurrent2);
            this.groupBox2.Controls.Add(this.txtCurrent5);
            this.groupBox2.Controls.Add(this.txtCurrent9);
            this.groupBox2.Controls.Add(this.txtCurrent4);
            this.groupBox2.Controls.Add(this.txtCurrent3);
            this.groupBox2.Controls.Add(this.txtVoltage8);
            this.groupBox2.Controls.Add(this.txtVoltage0);
            this.groupBox2.Controls.Add(this.txtVoltage7);
            this.groupBox2.Controls.Add(this.txtVoltage1);
            this.groupBox2.Controls.Add(this.txtVoltage6);
            this.groupBox2.Controls.Add(this.txtVoltage2);
            this.groupBox2.Controls.Add(this.txtVoltage5);
            this.groupBox2.Controls.Add(this.txtVoltage9);
            this.groupBox2.Controls.Add(this.txtVoltage4);
            this.groupBox2.Controls.Add(this.txtVoltage3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 247);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Readings";
            // 
            // button29
            // 
            this.button29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button29.Location = new System.Drawing.Point(833, 128);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(84, 23);
            this.button29.TabIndex = 87;
            this.button29.Text = "Calibrar 0A";
            this.button29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button30.Location = new System.Drawing.Point(833, 157);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(84, 23);
            this.button30.TabIndex = 88;
            this.button30.Text = "Calibrar 2.9A";
            this.button30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button31.Location = new System.Drawing.Point(743, 128);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(84, 23);
            this.button31.TabIndex = 85;
            this.button31.Text = "Calibrar 0A";
            this.button31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button32.Location = new System.Drawing.Point(743, 157);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(84, 23);
            this.button32.TabIndex = 86;
            this.button32.Text = "Calibrar 2.9A";
            this.button32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button33.Location = new System.Drawing.Point(653, 128);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(84, 23);
            this.button33.TabIndex = 83;
            this.button33.Text = "Calibrar 0A";
            this.button33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button34.Location = new System.Drawing.Point(653, 157);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(84, 23);
            this.button34.TabIndex = 84;
            this.button34.Text = "Calibrar 2.9A";
            this.button34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button35.Location = new System.Drawing.Point(563, 128);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(84, 23);
            this.button35.TabIndex = 81;
            this.button35.Text = "Calibrar 0A";
            this.button35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button36.Location = new System.Drawing.Point(563, 157);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(84, 23);
            this.button36.TabIndex = 82;
            this.button36.Text = "Calibrar 2.9A";
            this.button36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button37.Location = new System.Drawing.Point(473, 128);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(84, 23);
            this.button37.TabIndex = 79;
            this.button37.Text = "Calibrar 0A";
            this.button37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button38.Location = new System.Drawing.Point(473, 157);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(84, 23);
            this.button38.TabIndex = 80;
            this.button38.Text = "Calibrar 2.9A";
            this.button38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button39.Location = new System.Drawing.Point(383, 128);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(84, 23);
            this.button39.TabIndex = 77;
            this.button39.Text = "Calibrar 0A";
            this.button39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button40.Location = new System.Drawing.Point(383, 157);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(84, 23);
            this.button40.TabIndex = 78;
            this.button40.Text = "Calibrar 2.9A";
            this.button40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button41.Location = new System.Drawing.Point(293, 128);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(84, 23);
            this.button41.TabIndex = 75;
            this.button41.Text = "Calibrar 0A";
            this.button41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button42.Location = new System.Drawing.Point(293, 157);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(84, 23);
            this.button42.TabIndex = 76;
            this.button42.Text = "Calibrar 2.9A";
            this.button42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button43.Location = new System.Drawing.Point(201, 128);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(84, 23);
            this.button43.TabIndex = 73;
            this.button43.Text = "Calibrar 0A";
            this.button43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button44.Location = new System.Drawing.Point(201, 157);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(84, 23);
            this.button44.TabIndex = 74;
            this.button44.Text = "Calibrar 2.9A";
            this.button44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button45.Location = new System.Drawing.Point(110, 128);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(84, 23);
            this.button45.TabIndex = 71;
            this.button45.Text = "Calibrar 0A";
            this.button45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button46
            // 
            this.button46.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button46.Location = new System.Drawing.Point(110, 157);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(84, 23);
            this.button46.TabIndex = 72;
            this.button46.Text = "Calibrar 2.9A";
            this.button46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button47
            // 
            this.button47.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button47.Location = new System.Drawing.Point(18, 128);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(84, 23);
            this.button47.TabIndex = 69;
            this.button47.Text = "Calibrar 0A";
            this.button47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button48
            // 
            this.button48.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button48.Location = new System.Drawing.Point(18, 157);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(84, 23);
            this.button48.TabIndex = 70;
            this.button48.Text = "Calibrar 2.9A";
            this.button48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button48.UseVisualStyleBackColor = true;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button27
            // 
            this.button27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button27.Location = new System.Drawing.Point(833, 19);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(84, 23);
            this.button27.TabIndex = 67;
            this.button27.Text = "Calibrar 0V";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button28.Location = new System.Drawing.Point(833, 48);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(84, 23);
            this.button28.TabIndex = 68;
            this.button28.Text = "Calibrar 13.3V";
            this.button28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button25.Location = new System.Drawing.Point(743, 19);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(84, 23);
            this.button25.TabIndex = 65;
            this.button25.Text = "Calibrar 0V";
            this.button25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button26.Location = new System.Drawing.Point(743, 48);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(84, 23);
            this.button26.TabIndex = 66;
            this.button26.Text = "Calibrar 13.3V";
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button23.Location = new System.Drawing.Point(653, 19);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(84, 23);
            this.button23.TabIndex = 63;
            this.button23.Text = "Calibrar 0V";
            this.button23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button24.Location = new System.Drawing.Point(653, 48);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 23);
            this.button24.TabIndex = 64;
            this.button24.Text = "Calibrar 13.3V";
            this.button24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button21.Location = new System.Drawing.Point(563, 19);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(84, 23);
            this.button21.TabIndex = 61;
            this.button21.Text = "Calibrar 0V";
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button22.Location = new System.Drawing.Point(563, 48);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(84, 23);
            this.button22.TabIndex = 62;
            this.button22.Text = "Calibrar 13.3V";
            this.button22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button19.Location = new System.Drawing.Point(473, 19);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 23);
            this.button19.TabIndex = 59;
            this.button19.Text = "Calibrar 0V";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button20.Location = new System.Drawing.Point(473, 48);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 23);
            this.button20.TabIndex = 60;
            this.button20.Text = "Calibrar 13.3V";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button17.Location = new System.Drawing.Point(383, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 23);
            this.button17.TabIndex = 57;
            this.button17.Text = "Calibrar 0V";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button18.Location = new System.Drawing.Point(383, 48);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 23);
            this.button18.TabIndex = 58;
            this.button18.Text = "Calibrar 13.3V";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button15.Location = new System.Drawing.Point(293, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 23);
            this.button15.TabIndex = 55;
            this.button15.Text = "Calibrar 0V";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button16.Location = new System.Drawing.Point(293, 48);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 23);
            this.button16.TabIndex = 56;
            this.button16.Text = "Calibrar 13.3V";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button13.Location = new System.Drawing.Point(201, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 23);
            this.button13.TabIndex = 53;
            this.button13.Text = "Calibrar 0V";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button14.Location = new System.Drawing.Point(201, 48);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 23);
            this.button14.TabIndex = 54;
            this.button14.Text = "Calibrar 13.3V";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button11.Location = new System.Drawing.Point(110, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 23);
            this.button11.TabIndex = 51;
            this.button11.Text = "Calibrar 0V";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button12.Location = new System.Drawing.Point(110, 48);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 23);
            this.button12.TabIndex = 52;
            this.button12.Text = "Calibrar 13.3V";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button9.Location = new System.Drawing.Point(18, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 49;
            this.button9.Text = "Calibrar 0V";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.Location = new System.Drawing.Point(18, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 23);
            this.button10.TabIndex = 50;
            this.button10.Text = "Calibrar 13.3V";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Corrente 3:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Corrente 2:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(833, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Corrente 9:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(743, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Corrente 8:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(653, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Corrente 7:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(563, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Corrente 6:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(473, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Corrente 5:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(383, 185);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Corrente 4:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(110, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Corrente 1:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Corrente 0:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tensão 3:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tensão 2:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(833, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tensão 9:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tensão 8:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tensão 7:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tensão 6:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tensão 5:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tensão 4:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tensão 1:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tensão 0:";
            // 
            // txtCurrent8
            // 
            this.txtCurrent8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent8.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent8.Location = new System.Drawing.Point(743, 201);
            this.txtCurrent8.Name = "txtCurrent8";
            this.txtCurrent8.ReadOnly = true;
            this.txtCurrent8.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent8.TabIndex = 28;
            // 
            // txtCurrent0
            // 
            this.txtCurrent0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent0.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent0.Location = new System.Drawing.Point(18, 201);
            this.txtCurrent0.Name = "txtCurrent0";
            this.txtCurrent0.ReadOnly = true;
            this.txtCurrent0.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent0.TabIndex = 19;
            // 
            // txtCurrent7
            // 
            this.txtCurrent7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent7.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent7.Location = new System.Drawing.Point(653, 201);
            this.txtCurrent7.Name = "txtCurrent7";
            this.txtCurrent7.ReadOnly = true;
            this.txtCurrent7.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent7.TabIndex = 27;
            // 
            // txtCurrent1
            // 
            this.txtCurrent1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent1.Location = new System.Drawing.Point(110, 201);
            this.txtCurrent1.Name = "txtCurrent1";
            this.txtCurrent1.ReadOnly = true;
            this.txtCurrent1.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent1.TabIndex = 20;
            // 
            // txtCurrent6
            // 
            this.txtCurrent6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent6.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent6.Location = new System.Drawing.Point(563, 201);
            this.txtCurrent6.Name = "txtCurrent6";
            this.txtCurrent6.ReadOnly = true;
            this.txtCurrent6.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent6.TabIndex = 26;
            // 
            // txtCurrent2
            // 
            this.txtCurrent2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent2.Location = new System.Drawing.Point(201, 201);
            this.txtCurrent2.Name = "txtCurrent2";
            this.txtCurrent2.ReadOnly = true;
            this.txtCurrent2.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent2.TabIndex = 21;
            // 
            // txtCurrent5
            // 
            this.txtCurrent5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent5.Location = new System.Drawing.Point(473, 201);
            this.txtCurrent5.Name = "txtCurrent5";
            this.txtCurrent5.ReadOnly = true;
            this.txtCurrent5.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent5.TabIndex = 25;
            // 
            // txtCurrent9
            // 
            this.txtCurrent9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent9.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent9.Location = new System.Drawing.Point(833, 201);
            this.txtCurrent9.Name = "txtCurrent9";
            this.txtCurrent9.ReadOnly = true;
            this.txtCurrent9.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent9.TabIndex = 22;
            // 
            // txtCurrent4
            // 
            this.txtCurrent4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent4.Location = new System.Drawing.Point(383, 201);
            this.txtCurrent4.Name = "txtCurrent4";
            this.txtCurrent4.ReadOnly = true;
            this.txtCurrent4.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent4.TabIndex = 24;
            // 
            // txtCurrent3
            // 
            this.txtCurrent3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent3.Location = new System.Drawing.Point(293, 201);
            this.txtCurrent3.Name = "txtCurrent3";
            this.txtCurrent3.ReadOnly = true;
            this.txtCurrent3.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent3.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(293, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Calibrar 2.9A";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(201, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Calibrar 0A";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 76);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button7.Location = new System.Drawing.Point(18, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Resetar 0V";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.Location = new System.Drawing.Point(18, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Resetar 0A";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.Location = new System.Drawing.Point(110, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Resetar 13.3V";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.Location = new System.Drawing.Point(110, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Resetar 2.9A";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(201, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calibrar 0V";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(293, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calibrar 13.3V";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMessageBox);
            this.groupBox4.Location = new System.Drawing.Point(419, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 136);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // reconnectTimer
            // 
            this.reconnectTimer.Enabled = true;
            this.reconnectTimer.Tick += new System.EventHandler(this.reconnectTimer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 433);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Jiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox bxPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Timer requestReadsTimer;
        private System.Windows.Forms.TextBox txtVoltage0;
        private System.Windows.Forms.TextBox txtVoltage8;
        private System.Windows.Forms.TextBox txtVoltage7;
        private System.Windows.Forms.TextBox txtVoltage6;
        private System.Windows.Forms.TextBox txtVoltage5;
        private System.Windows.Forms.TextBox txtVoltage4;
        private System.Windows.Forms.TextBox txtVoltage3;
        private System.Windows.Forms.TextBox txtVoltage9;
        private System.Windows.Forms.TextBox txtVoltage2;
        private System.Windows.Forms.TextBox txtVoltage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrent8;
        private System.Windows.Forms.TextBox txtCurrent0;
        private System.Windows.Forms.TextBox txtCurrent7;
        private System.Windows.Forms.TextBox txtCurrent1;
        private System.Windows.Forms.TextBox txtCurrent6;
        private System.Windows.Forms.TextBox txtCurrent2;
        private System.Windows.Forms.TextBox txtCurrent5;
        private System.Windows.Forms.TextBox txtCurrent9;
        private System.Windows.Forms.TextBox txtCurrent4;
        private System.Windows.Forms.TextBox txtCurrent3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Timer reconnectTimer;
    }
}

