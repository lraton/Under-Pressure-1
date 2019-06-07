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
        public string tskmsg;
        Timer tmrtsk;
        bool isDataRecived;
        bool taskOnOff;
        const String STX = "\u0002";
        const String ETX = "\u0003";
        public Tsk()
        {
            isDataRecived = false;
            tmrtsk = new Timer();
            tmrtsk.Interval = 200;
            tmrtsk.Enabled = false;
            taskOnOff = false;
            tmrtsk.Elapsed += Tmrtsk_Elapsed;
            serial = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            serial.DataReceived += Serial_DataReceived;
        }

        //Open close task
        public void taskEnable(bool onOff)
        {
            taskOnOff = onOff;
            if (onOff)
            {
                tmrtsk.Enabled = true;
            }
            else
            {
                tmrtsk.Enabled = false;
            }
        }



        //Open close port
        public void OpenComPort(bool onOff)
        {
            if (onOff)
            {
                serial.Open();
                
                    tmrtsk.Enabled = true;
                
                
            }
            else
            {
                serial.Close();
            }

        }




        //Timer Task send
        private void Tmrtsk_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmrtsk.Enabled = false;
            isDataRecived = false;
            if (serial.IsOpen)
                serial.Write(STX + "Giovanni" + ETX);

        }
        //task recive
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (taskOnOff)
            {
                tskmsg = serial.ReadExisting();
                isDataRecived = true;
                Split();
            }
            else
            {
                serial.ReadExisting();
            }
        }

        // split
        public String Split()
        {
            if (isDataRecived)
            {
                tmrtsk.Enabled = true;
                // String [] spl=tskmsg.Split('|');
                //  if ((  spl[0] == STX)&&(spl[5]==ETX )){

                // }
                
            }
            return tskmsg;
        }
    }
}
