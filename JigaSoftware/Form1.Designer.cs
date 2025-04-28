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
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bxPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
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
            this.txtMessageBox.Location = new System.Drawing.Point(404, 141);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBox.Size = new System.Drawing.Size(463, 247);
            this.txtMessageBox.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(323, 365);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
            this.txtVoltage0.Location = new System.Drawing.Point(18, 38);
            this.txtVoltage0.Name = "txtVoltage0";
            this.txtVoltage0.ReadOnly = true;
            this.txtVoltage0.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage0.TabIndex = 9;
            // 
            // txtVoltage1
            // 
            this.txtVoltage1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage1.Location = new System.Drawing.Point(102, 38);
            this.txtVoltage1.Name = "txtVoltage1";
            this.txtVoltage1.ReadOnly = true;
            this.txtVoltage1.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage1.TabIndex = 10;
            // 
            // txtVoltage2
            // 
            this.txtVoltage2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage2.Location = new System.Drawing.Point(186, 38);
            this.txtVoltage2.Name = "txtVoltage2";
            this.txtVoltage2.ReadOnly = true;
            this.txtVoltage2.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage2.TabIndex = 11;
            // 
            // txtVoltage9
            // 
            this.txtVoltage9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage9.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage9.Location = new System.Drawing.Point(774, 38);
            this.txtVoltage9.Name = "txtVoltage9";
            this.txtVoltage9.ReadOnly = true;
            this.txtVoltage9.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage9.TabIndex = 12;
            // 
            // txtVoltage3
            // 
            this.txtVoltage3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage3.Location = new System.Drawing.Point(270, 38);
            this.txtVoltage3.Name = "txtVoltage3";
            this.txtVoltage3.ReadOnly = true;
            this.txtVoltage3.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage3.TabIndex = 13;
            // 
            // txtVoltage4
            // 
            this.txtVoltage4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage4.Location = new System.Drawing.Point(354, 38);
            this.txtVoltage4.Name = "txtVoltage4";
            this.txtVoltage4.ReadOnly = true;
            this.txtVoltage4.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage4.TabIndex = 14;
            // 
            // txtVoltage5
            // 
            this.txtVoltage5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage5.Location = new System.Drawing.Point(438, 38);
            this.txtVoltage5.Name = "txtVoltage5";
            this.txtVoltage5.ReadOnly = true;
            this.txtVoltage5.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage5.TabIndex = 15;
            // 
            // txtVoltage6
            // 
            this.txtVoltage6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage6.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage6.Location = new System.Drawing.Point(522, 38);
            this.txtVoltage6.Name = "txtVoltage6";
            this.txtVoltage6.ReadOnly = true;
            this.txtVoltage6.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage6.TabIndex = 16;
            // 
            // txtVoltage7
            // 
            this.txtVoltage7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage7.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage7.Location = new System.Drawing.Point(606, 38);
            this.txtVoltage7.Name = "txtVoltage7";
            this.txtVoltage7.ReadOnly = true;
            this.txtVoltage7.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage7.TabIndex = 17;
            // 
            // txtVoltage8
            // 
            this.txtVoltage8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVoltage8.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVoltage8.Location = new System.Drawing.Point(690, 38);
            this.txtVoltage8.Name = "txtVoltage8";
            this.txtVoltage8.ReadOnly = true;
            this.txtVoltage8.Size = new System.Drawing.Size(69, 20);
            this.txtVoltage8.TabIndex = 18;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(855, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Readings";
            // 
            // txtCurrent8
            // 
            this.txtCurrent8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent8.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent8.Location = new System.Drawing.Point(690, 83);
            this.txtCurrent8.Name = "txtCurrent8";
            this.txtCurrent8.ReadOnly = true;
            this.txtCurrent8.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent8.TabIndex = 28;
            // 
            // txtCurrent0
            // 
            this.txtCurrent0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent0.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent0.Location = new System.Drawing.Point(18, 83);
            this.txtCurrent0.Name = "txtCurrent0";
            this.txtCurrent0.ReadOnly = true;
            this.txtCurrent0.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent0.TabIndex = 19;
            // 
            // txtCurrent7
            // 
            this.txtCurrent7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent7.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent7.Location = new System.Drawing.Point(606, 83);
            this.txtCurrent7.Name = "txtCurrent7";
            this.txtCurrent7.ReadOnly = true;
            this.txtCurrent7.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent7.TabIndex = 27;
            // 
            // txtCurrent1
            // 
            this.txtCurrent1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent1.Location = new System.Drawing.Point(102, 83);
            this.txtCurrent1.Name = "txtCurrent1";
            this.txtCurrent1.ReadOnly = true;
            this.txtCurrent1.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent1.TabIndex = 20;
            // 
            // txtCurrent6
            // 
            this.txtCurrent6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent6.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent6.Location = new System.Drawing.Point(522, 83);
            this.txtCurrent6.Name = "txtCurrent6";
            this.txtCurrent6.ReadOnly = true;
            this.txtCurrent6.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent6.TabIndex = 26;
            // 
            // txtCurrent2
            // 
            this.txtCurrent2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent2.Location = new System.Drawing.Point(186, 83);
            this.txtCurrent2.Name = "txtCurrent2";
            this.txtCurrent2.ReadOnly = true;
            this.txtCurrent2.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent2.TabIndex = 21;
            // 
            // txtCurrent5
            // 
            this.txtCurrent5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent5.Location = new System.Drawing.Point(438, 83);
            this.txtCurrent5.Name = "txtCurrent5";
            this.txtCurrent5.ReadOnly = true;
            this.txtCurrent5.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent5.TabIndex = 25;
            // 
            // txtCurrent9
            // 
            this.txtCurrent9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent9.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent9.Location = new System.Drawing.Point(774, 83);
            this.txtCurrent9.Name = "txtCurrent9";
            this.txtCurrent9.ReadOnly = true;
            this.txtCurrent9.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent9.TabIndex = 22;
            // 
            // txtCurrent4
            // 
            this.txtCurrent4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent4.Location = new System.Drawing.Point(354, 83);
            this.txtCurrent4.Name = "txtCurrent4";
            this.txtCurrent4.ReadOnly = true;
            this.txtCurrent4.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent4.TabIndex = 24;
            // 
            // txtCurrent3
            // 
            this.txtCurrent3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrent3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrent3.Location = new System.Drawing.Point(270, 83);
            this.txtCurrent3.Name = "txtCurrent3";
            this.txtCurrent3.ReadOnly = true;
            this.txtCurrent3.Size = new System.Drawing.Size(69, 20);
            this.txtCurrent3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tensão 0:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tensão 1:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tensão 4:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tensão 5:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tensão 6:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tensão 7:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tensão 8:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tensão 9:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tensão 2:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tensão 3:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Corrente 3:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Corrente 2:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(774, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Corrente 9:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(690, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Corrente 8:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(606, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Corrente 7:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(522, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Corrente 6:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(438, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Corrente 5:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(354, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Corrente 4:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(102, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Corrente 1:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Corrente 0:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Jiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox bxPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Button btnTest;
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
    }
}

