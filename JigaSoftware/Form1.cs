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
            foreach(var baudRate in BaudRates)
            {
                bxBaudRate.Items.Add(baudRate);
            }
            bxBaudRate.SelectedIndex = 1;
            foreach(var numBits in NumBits)
            {
                bxNumBits.Items.Add(numBits);
            }
            bxNumBits.SelectedIndex = 1;
            foreach (var stopBits in StopBitsArray)
            {
                bxStopBits.Items.Add(stopBits);
            }
            bxStopBits.SelectedIndex = 1;
            foreach(var parity in Paritys)
            {
                bxParity.Items.Add(parity);
            }
            bxParity.SelectedIndex = 0;
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

            try
            {
                Serial.BaudRate = int.Parse(bxBaudRate.Text.ToString());
            }
            catch
            {
                txtMessageBox.AppendText(Environment.NewLine + "Erro ao definir o baud rate");
                return;
            }

            try
            {
                Serial.DataBits = int.Parse(bxNumBits.Text.ToString());
            }
            catch
            {
                txtMessageBox.AppendText(Environment.NewLine + "Erro ao definir o os stop bits");
                return;
            }

            try
            {
                Serial.StopBits = (StopBits) bxStopBits.SelectedIndex;
            }
            catch
            {
                txtMessageBox.AppendText(Environment.NewLine + "Erro ao definir o os stop bits");
                return;
            }

            try
            {
                Serial.Parity = (Parity) bxParity.SelectedIndex;
            }
            catch
            {
                txtMessageBox.AppendText(Environment.NewLine + "Erro ao definir a paridade");
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
            txtMessageBox.AppendText(Environment.NewLine + "Stop Bits: " + Serial.StopBits);
            txtMessageBox.AppendText(Environment.NewLine + "Parity: " + Serial.Parity);

            btnRefreshPorts.Enabled = false;
            bxPort.Enabled = false;
            bxBaudRate.Enabled = false;
            bxNumBits.Enabled = false;
            bxStopBits.Enabled = false;
            bxParity.Enabled = false;

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
            bxBaudRate.Enabled = true;
            bxNumBits.Enabled = true;
            bxStopBits.Enabled = true;
            bxParity.Enabled = true;
            btnConnect.Text = "Connect";

            txtMessageBox.AppendText(Environment.NewLine + "Serial desconectada");
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
                string msg = "UU" + (char)0x05 + (char)0x05 + "Teste" + (char)0x23 + (char)0x23;
                Serial.Write(msg);
            }
        }
    }
}
