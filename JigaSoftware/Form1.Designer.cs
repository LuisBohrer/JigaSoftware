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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.bxPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.BaudRate = 115200;
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialDataReceivedHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bxPort);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnRefreshPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(187, 23);
            this.progressBar1.TabIndex = 1;
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
            this.btnConnect.Location = new System.Drawing.Point(221, 205);
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
            this.txtMessageBox.Location = new System.Drawing.Point(332, 12);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBox.Size = new System.Drawing.Size(296, 247);
            this.txtMessageBox.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(553, 265);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Jiga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Button btnTest;
    }
}

