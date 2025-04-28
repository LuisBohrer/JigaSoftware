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
using System.Timers;
using System.Security.Cryptography.X509Certificates;

namespace JigaSoftware
{
    public partial class Form : System.Windows.Forms.Form
    {
        SerialProtocol serialProtocol = new SerialProtocol();

        public Byte[] serialDataRcv = new Byte[150];
        public bool newDataFlag;

        public enum JigaOpcodes
        {
            INCOMPLETE_REQUEST,
            INVALID_REQUEST,
            CALIBRATE_VOLTAGE_MIN,
            CALIBRATE_VOLTAGE_MAX,
            CALIBRATE_CURRRENT_MIN,
            CALIBRATE_CURRRENT_MAX,
            SEND_VOLTAGE_READS = 22,
            SEND_CURRENT_READS,
            SEND_ALL_READS,
            SET_MODBUS_CONFIG,
            CHANGE_SCALE,
            LOGS,
        }

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
            if (!Serial.IsOpen)
            {
                return;
            }

            int dataSize = Serial.BytesToRead;
            for(int i = 0; i < dataSize; i++)
            {
                serialDataRcv[i] = Convert.ToByte(Serial.ReadByte());
            }
            newDataFlag = true;

            if (!serialProtocol.commandUnParse(serialDataRcv))
            {
                MethodInvoker errorMessage = delegate ()
                {
                    txtMessageBox.AppendText(Environment.NewLine + "Mensagem inválida");
                };

                if (this.InvokeRequired)
                {
                    this.Invoke(errorMessage);
                }
                else
                {
                    errorMessage();
                }
                return;
            }

            treatSerialMessage();

            MethodInvoker printMessage = delegate ()
            {
                txtMessageBox.AppendText(Environment.NewLine + System.Text.Encoding.UTF8.GetString(serialDataRcv, 0, dataSize));
            };

            if (this.InvokeRequired)
            {
                this.Invoke(printMessage);
            }
            else
            {
                printMessage();
            }
        }

        public void treatSerialMessage()
        {
            const int NUMBER_OF_CHANNELS = 10;
            float[] voltageReads = new float[NUMBER_OF_CHANNELS];
            float[] currentReads = new float[NUMBER_OF_CHANNELS];
            MethodInvoker updateReads = delegate ()
            {
                txtVoltage0.Text = voltageReads[0].ToString() + " V";
                txtVoltage1.Text = voltageReads[1].ToString() + " V";
                txtVoltage2.Text = voltageReads[2].ToString() + " V";
                txtVoltage3.Text = voltageReads[3].ToString() + " V";
                txtVoltage4.Text = voltageReads[4].ToString() + " V";
                txtVoltage5.Text = voltageReads[5].ToString() + " V";
                txtVoltage6.Text = voltageReads[6].ToString() + " V";
                txtVoltage7.Text = voltageReads[7].ToString() + " V";
                txtVoltage8.Text = voltageReads[8].ToString() + " V";
                txtVoltage9.Text = voltageReads[9].ToString() + " V";

                txtCurrent0.Text = currentReads[0].ToString() + " mA";
                txtCurrent1.Text = currentReads[1].ToString() + " mA";
                txtCurrent2.Text = currentReads[2].ToString() + " mA";
                txtCurrent3.Text = currentReads[3].ToString() + " mA";
                txtCurrent4.Text = currentReads[4].ToString() + " mA";
                txtCurrent5.Text = currentReads[5].ToString() + " mA";
                txtCurrent6.Text = currentReads[6].ToString() + " mA";
                txtCurrent7.Text = currentReads[7].ToString() + " mA";
                txtCurrent8.Text = currentReads[8].ToString() + " mA";
                txtCurrent9.Text = currentReads[9].ToString() + " mA";
            };
            switch (serialProtocol.opCode)
            {
                case (int)JigaOpcodes.SEND_ALL_READS:
                    if(serialProtocol.dataFrameSize/4 < NUMBER_OF_CHANNELS * 2)
                    {
                        return;
                    }
                    for(int i = 0; i < serialProtocol.dataFrameSize/4; i++)
                    {
                        float value = System.BitConverter.ToSingle(serialProtocol.dataFrame, i*4);
                        if (i % 2 == 0)
                        {
                            voltageReads[i / 2] = (float)Math.Round(value, 2);
                        }
                        else
                        {
                            currentReads[i / 2] = (float)Math.Round(value, 2);
                        }
                    }
                    this.Invoke(updateReads);
                    break;
                default:
                    break;
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
                byte[] testReads = new byte[80];
                for(int i = 0; i < 10; i++)
                {
                    byte[] byteList = System.BitConverter.GetBytes((float)10.1*i);
                    byteList.CopyTo(testReads, i*4);
                }
                SendCommandSerial((byte)JigaOpcodes.SEND_ALL_READS, testReads);
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Serial.IsOpen)
            {
                Serial.Close();
            }
        }

        private void requestReadsTimer_Tick(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.SEND_ALL_READS);
        }
    }
}
