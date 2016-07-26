using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace ControlMachine
{
    public class zigbeeConnect
    {
        public static SerialPort serialPort1 = new SerialPort();

        public void controlFrame(string Address64bit,string Address16bit,byte statusControl)
        {
            byte[] add64 = new byte[8];
            byte[] add16 = new byte[2];

            string[] HL64 = Address64bit.Split(' ');
            string[] HL16 = Address16bit.Split(' ');
            int i = 0;
            foreach (string hex in HL64)
            {
                int val = Convert.ToInt32(hex, 16);
                add64[i] = Convert.ToByte(val);
                i++;
            }

            i = 0;
            foreach (string hex in HL16)
            {
                int val = Convert.ToInt32(hex, 16);
                add16[i] = Convert.ToByte(val);
                i++;
            }

            byte[] frame = { 0x7E, 0x00, 0x0F, 0x10, 0x00, add64[0], add64[1], add64[2], add64[3], add64[4], add64[5], add64[6], add64[7], add16[0], add16[1], 0x00, 0x00, statusControl,0x00 };

            byte sum = 0x00;
            for (int j = 3; j < 18; j++)
            {
                sum += frame[j];
            }

            
            sum = (byte)(0xFF - sum);
            
            frame[18] = sum;

            serialPort1.DiscardInBuffer();
            TransimitPacket(frame,19);

        }

        public void setLimitLoad(string Address64bit, string Address16bit, byte HB,byte LB)
        {
            byte[] add64 = new byte[8];
            byte[] add16 = new byte[2];

            string[] HL64 = Address64bit.Split(' ');
            string[] HL16 = Address16bit.Split(' ');
            int i = 0;
            foreach (string hex in HL64)
            {
                int val = Convert.ToInt32(hex, 16);
                add64[i] = Convert.ToByte(val);
                i++;
            }

            i = 0;
            foreach (string hex in HL16)
            {
                int val = Convert.ToInt32(hex, 16);
                add16[i] = Convert.ToByte(val);
                i++;
            }

            byte[] frame = { 0x7E, 0x00, 0x11, 0x10, 0x00, add64[0], add64[1], add64[2], add64[3], add64[4], add64[5], add64[6], add64[7], add16[0], add16[1], 0x00, 0x00, 0x04,HB,LB, 0x00 };

            byte sum = 0x00;
            for (int j = 3; j < 20; j++)
            {
                sum += frame[j];
            }


            sum = (byte)(0xFF - sum);

            frame[20] = sum;
            serialPort1.DiscardInBuffer();
            TransimitPacket(frame, 21);
        }

        public void TransimitPacket(byte[] packet, int size)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(packet, 0, size);
                    serialPort1.DiscardOutBuffer();
                }
                              
            }
            catch (Exception ex)
            {
                serialPort1.Write(packet, 0, size);
                serialPort1.DiscardOutBuffer();
            }
        }

        public List<byte> recivePacket()
        {
            List<byte> packet = new List<byte>();
            try
            {
                if ((serialPort1.IsOpen) && (serialPort1.BytesToRead > 0))
                {
                    byte startPacket = Convert.ToByte(serialPort1.ReadByte());
                    if (startPacket == 0x7E)
                    {
                        packet.Add(startPacket);
                        packet.Add(Convert.ToByte(serialPort1.ReadByte()));
                        packet.Add(Convert.ToByte(serialPort1.ReadByte()));
                        byte sum = 0x00;
                        for (int i = 3; i < packet[2] + 3; i++)
                        {
                            packet.Add(Convert.ToByte(serialPort1.ReadByte()));
                            sum += packet[i];
                        }
                        packet.Add(Convert.ToByte(serialPort1.ReadByte()));
                        sum = (byte)(0xFF - sum);
                        if (sum != packet[packet.Count - 1])
                        {
                            packet.Clear();
                            serialPort1.DiscardInBuffer();
                        }

                        foreach (byte idx in packet)
                        {
                            Console.Write("{0:X} ", idx);
                        }
                        Console.WriteLine();

                    }

                }
            }
            catch (Exception ex)
            {
                
            }
                
                
                return packet;
            
        }
        
        
        public string[] getAvailablePort()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        public void openPort(string portName,int baudRate)
        {
            serialPort1.PortName = portName;
            serialPort1.BaudRate = baudRate;
            serialPort1.Open();
            serialPort1.DiscardInBuffer();
        }
        public void closePort()
        {
            serialPort1.Close();
        }
        
        
    }
}
