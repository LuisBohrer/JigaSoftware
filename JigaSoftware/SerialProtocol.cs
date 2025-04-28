using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigaSoftware
{
    class SerialProtocol
    {
        public byte opCode;
        public byte dataFrameSize;
        public Byte[] dataFrame = new Byte[100];
        public byte startByte = 0x23;
        public byte endByte = 0x40;

        public byte[] commandParse(byte opcode, params byte[] parametros)
        {
            Byte[] dataParsed = new Byte[5 + parametros.Length];

            dataParsed[0] = startByte;
            dataParsed[1] = startByte;
            dataParsed[2] = opcode;
            dataParsed[3] = (byte)parametros.Length;
            for (int i = 0; i < parametros.Length; i++)
            {
                dataParsed[4 + i] = parametros[i];
            }
            dataParsed[dataParsed.Length - 1] = endByte;

            return dataParsed;
        }


        public bool commandUnParse(byte[] frame)
        {
            if(frame.Length < 4)
            {
                return false;
            }

            int opCodeIndex = 0;
            int dataFrameEndIndex = 0;

            for (int i = 0; i < frame.Length - 1; i++)
            {
                if (frame[i] == startByte && frame[i + 1] == startByte && i < frame.Length - 2)
                {
                    opCodeIndex = i + 2;
                }
                else if (frame[i] == endByte && i > 2)
                {
                    dataFrameEndIndex = i;
                    break;
                }
            }

            if (opCodeIndex == 0 || opCodeIndex > 100 || dataFrameEndIndex == 0 || frame == null)
            {
                opCode = 0;
                dataFrameSize = 0;
                return false;
            }

            opCode = frame[opCodeIndex];
            dataFrameSize = frame[opCodeIndex + 1];
            if (frame[opCodeIndex + dataFrameSize + 2] == endByte)
            {
                for (int i = 0; i < dataFrameSize; i++)
                {
                    dataFrame[i] = frame[i + opCodeIndex + 2];
                }
                return true;
            }
            else
            {
                opCode = 0;
                dataFrameSize = 0;
                return false;
            }
        }

        public string ASCIItoHex(string Value)
        {
            int count = 0;

            StringBuilder sb = new StringBuilder();

            foreach (byte b in Value)
            {
                if (count < Value.Length)
                {
                    if (!(Value[count] == 0x0a || Value[count] == 0x0d))
                        sb.Append(string.Format("{0:x2}", b));
                    else
                        sb.Append(string.Format("\n\r", b));
                }

                count++;
            }

            return sb.ToString();
        }
    }
}
