using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProvaLoccioni
{
    class Tsk
    {
        SerialPort serial;
        string tskmsg;
        Timer tmrtsk;
        bool isDataRecived;
        public Tsk()
        {
            isDataRecived = false;
            tmrtsk = new Timer();
            tmrtsk.Interval = 200;
            tmrtsk.Enabled = true;
            tmrtsk.Elapsed += Tmrtsk_Elapsed;
            serial = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            serial.DataReceived += Serial_DataReceived;
        }



        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            tskmsg = serial.ReadExisting();
            isDataRecived = true;
            Split();

        }

        public void OpenComPort()
        {
            serial.Open();
        }
        public void CloseComPort()
        {
            serial.Close();
        }

        public String Split()
        {
            tmrtsk.Enabled = true;
            String [] spl=tsk.Split("|");
            if ((  spl[0] == "STX")&&(spl[5] )){
        }
            return tskmsg;
        }

        private void Tmrtsk_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmrtsk.Enabled = false;

            isDataRecived = false;
            byte Stx = 0x02;
            byte Etx = 0x03;
            if (!serial.IsOpen)
                OpenComPort();
            serial.Write(Stx + "Giovanni" + Etx);
        }



    }
}
