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

        const UInt16 serialDataSize = 150;
        public Byte[] serialDataRcv = new Byte[serialDataSize];
        public bool newDataFlag;

        public enum JigaOpcodes
        {
            INCOMPLETE_REQUEST,
            INVALID_REQUEST,
            CALIBRATE_VOLTAGE_MIN,
            CALIBRATE_VOLTAGE_MAX,
            CALIBRATE_CURRENT_MIN,
            CALIBRATE_CURRENT_MAX,
            RESET_VOLTAGE_MIN,
            RESET_VOLTAGE_MAX,
            RESET_CURRENT_MIN,
            RESET_CURRENT_MAX,
            SEND_VOLTAGE_READS,
            SEND_CURRENT_READS,
            SEND_ALL_READS,
            SET_MODBUS_CONFIG,
            LOGS,
        }

        const UInt16 MIN_BOARD_READ = 0;
        const UInt16 MAX_BOARD_READ = 4095;
        const UInt16 MAX_BOARD_READ_CURRENT = 2188;
        const float MIN_VOLTAGE_READ = 0.0f;
        const float MAX_VOLTAGE_READ = 13.3f;
        const float MIN_CURRENT_READ = 0.0f;
        const float MAX_CURRENT_READ = 1500.0f;

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
            for (int i = 0; i < dataSize && i < serialDataSize; i++)
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
                string msgEnd = serialProtocol.dataFrame[0] < 10 ? ("do canal " + serialProtocol.dataFrame[0].ToString())
                                                                    : "de todos os canais";
                switch ((JigaOpcodes)serialProtocol.opCode) 
                {
                    case JigaOpcodes.CALIBRATE_VOLTAGE_MIN:
                        txtMessageBox.AppendText(Environment.NewLine + "Calibração 0V " + msgEnd);
                        break;
                    case JigaOpcodes.CALIBRATE_VOLTAGE_MAX:
                        txtMessageBox.AppendText(Environment.NewLine + "Calibração 13.3V " + msgEnd);
                        break;
                    case JigaOpcodes.CALIBRATE_CURRENT_MIN:
                        txtMessageBox.AppendText(Environment.NewLine + "Calibração 0A " + msgEnd);
                        break;
                    case JigaOpcodes.CALIBRATE_CURRENT_MAX:
                        txtMessageBox.AppendText(Environment.NewLine + "Calibração 2.94A " + msgEnd);
                        break;
                    case JigaOpcodes.RESET_VOLTAGE_MIN:
                        txtMessageBox.AppendText(Environment.NewLine + "Reset 0V " + msgEnd);
                        break;
                    case JigaOpcodes.RESET_VOLTAGE_MAX:
                        txtMessageBox.AppendText(Environment.NewLine + "Reset 13.3V " + msgEnd);
                        break;
                    case JigaOpcodes.RESET_CURRENT_MIN:
                        txtMessageBox.AppendText(Environment.NewLine + "Reset 0A " + msgEnd);
                        break;
                    case JigaOpcodes.RESET_CURRENT_MAX:
                        txtMessageBox.AppendText(Environment.NewLine + "Reset 2.94A " + msgEnd);
                        break;
                    default:
                        txtMessageBox.AppendText(Environment.NewLine + "Mensagem recebida!");
                        break;
                }
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

        public float changeScales(float value, float fromMin, float fromMax, float toMin, float toMax)
        {
            return (float)(toMin + (value - fromMin) / (fromMax - fromMin) * (toMax - toMin));
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
                    if (serialProtocol.dataFrameSize / 2 < NUMBER_OF_CHANNELS * 2)
                    {
                        return;
                    }
                    for (int i = 0; i < serialProtocol.dataFrameSize / 2; i++)
                    {
                        UInt16 value = System.BitConverter.ToUInt16(serialProtocol.dataFrame, i * 2);
                        if (i < 10)
                        {
                            voltageReads[i] = changeScales(value, MIN_BOARD_READ, MAX_BOARD_READ, MIN_VOLTAGE_READ, MAX_VOLTAGE_READ);
                        }
                        else
                        {
                            currentReads[i - 10] = changeScales(value, MIN_BOARD_READ, MAX_BOARD_READ_CURRENT, MIN_CURRENT_READ, MAX_CURRENT_READ);
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
            if (Serial.IsOpen)
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
            if (btnConnect.Text == "Connect")
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
                for (int i = 0; i < 10; i++)
                {
                    byte[] byteList = System.BitConverter.GetBytes((float)10.1 * i);
                    byteList.CopyTo(testReads, i * 4);
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

        private void reconnectTimer_Tick(object sender, EventArgs e)
        {
            if(btnConnect.Text == "Disconnect" && !Serial.IsOpen)
            {
                ConnectSerial();
            }
        }

        private void requestReadsTimer_Tick(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.SEND_ALL_READS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.RESET_VOLTAGE_MIN);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.RESET_VOLTAGE_MAX);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.RESET_CURRENT_MIN);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.RESET_CURRENT_MAX);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 5);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 6);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 7);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 8);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MIN, 9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 3);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 4);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 5);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 6);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 7);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 8);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_VOLTAGE_MAX, 9);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 0);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 0);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 1);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 2);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 3);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 4);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 5);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 6);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 7);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 8);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MAX, 9);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 1);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 2);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 3);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 4);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 5);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 6);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 7);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 8);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            SendCommandSerial((byte)JigaOpcodes.CALIBRATE_CURRENT_MIN, 9);
        }
    }
}
