using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace JigaSoftware
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly int[] BaudRates = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        private readonly int[] NumBits = { 7, 8, 9 };
        private readonly int[] StopBitsArray = { 0, 1, 2 };
        private readonly string[] Paritys = { "None", "Odd", "Even", "Mark", "Space" };

        SerialProtocol serialProtocol = new SerialProtocol();

        public Byte[] serialDataRcv = new Byte[150];
        public bool newDataFlag;

        private void SendCommandSerial(byte opcode, params byte[] parametros)
        {
            byte[] frame = serialProtocol.commandParse(opcode, parametros);

            if (Serial.IsOpen)
            {
                Serial.Write(frame, 0, frame.Length);
            }
        }

        public void SerialDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);

            int dataSize = Serial.BytesToRead;
            for(int i = 0; i < dataSize; i++)
            {
                serialDataRcv[i] = Convert.ToByte(Serial.ReadByte());
            }
            newDataFlag = true;

            if (!serialProtocol.commandUnParse(serialDataRcv))
            {
                return;
            }

            MethodInvoker methodInvokerDelegate = delegate ()
            {
                txtMessageBox.AppendText(Environment.NewLine + System.Text.Encoding.UTF8.GetString(serialDataRcv, 0, dataSize));
            };

            if (this.InvokeRequired)
            {
                this.Invoke(methodInvokerDelegate);
            }
            else
            {
                methodInvokerDelegate();
            }
        }

        public Form()
        {
            InitializeComponent();

            UpdatePorts();
            bxPort.SelectedIndex = 0;
        }

        private void UpdatePorts()
        {
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            Array.Sort(Ports);

            bxPort.Items.Clear();
            foreach (var port in Ports)
            {
                bxPort.Items.Add(port);
            }
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            UpdatePorts();
        }

        private void ConnectSerial()
        {
            try
            {
                Serial.PortName = bxPort.Text;
            }
            catch
            {
                txtMessageBox.AppendText(Environment.NewLine + "Erro ao definir a porta");
                return;
            }

            if (!Serial.IsOpen)
            {
                try
                {
                    Serial.Open();
                }
                catch
                {
                    txtMessageBox.AppendText(Environment.NewLine + "Erro ao abrir a serial");
                    return;
                }
            }
            txtMessageBox.AppendText(Environment.NewLine + "Serial aberta:");
            txtMessageBox.AppendText(Environment.NewLine + "Porta: " + Serial.PortName);
            txtMessageBox.AppendText(Environment.NewLine + "BaudRate: " + Serial.BaudRate);
            txtMessageBox.AppendText(Environment.NewLine + "Num Bits: " + Serial.DataBits);
            txtMessageBox.AppendText(Environment.NewLine + "Parity: " + Serial.Parity);
            txtMessageBox.AppendText(Environment.NewLine + "Stop Bits: " + Serial.StopBits);

            btnRefreshPorts.Enabled = false;
            bxPort.Enabled = false;

            btnConnect.Text = "Disconnect";
        }
        private void DisconnectSerial()
        {
            if(Serial.IsOpen)
            {
                Serial.Close();
            }
            btnRefreshPorts.Enabled = true;
            bxPort.Enabled = true;
            btnConnect.Text = "Connect";

            txtMessageBox.AppendText(Environment.NewLine + "Serial fechada");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(btnConnect.Text == "Connect")
            {
                ConnectSerial();
            }
            else
            {
                DisconnectSerial();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
            {
                string msg = "##" + (char)0x05 + (char)0x05 + "Teste" + (char)0x40;
                Serial.Write(msg);
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Close();
            }
        }
    }
}
