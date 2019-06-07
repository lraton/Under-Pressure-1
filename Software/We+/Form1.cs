using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaLoccioni
{
    public partial class Form1 : Form
    {

        Tsk tsk= new Tsk();
        bool portOnOff, taskOnOff;
        public Form1()
        {
            portOnOff = false;
            taskOnOff = false;
            tsk.OpenComPort(portOnOff);
            tsk.OpenComPort(taskOnOff);
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            String msg = tsk.Split();
            lblRes.Text = msg;
        }

  

        private void clock_Tick(object sender, EventArgs e)
        {
            
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void startStop_Click(object sender, EventArgs e)
        {
            portOnOff = !portOnOff;
            if (portOnOff)
            {
                ledOnOFF.BackColor = Color.Green;
                tsk.OpenComPort(portOnOff);
            }
            else
            {
                ledOnOFF.BackColor = Color.Red;
                tsk.OpenComPort(portOnOff);
            }
        }

        private void btnTaskOnOFF_Click(object sender, EventArgs e)
        {
            taskOnOff = !taskOnOff;
            if (taskOnOff)
            {
                ledTskOnOff.BackColor = Color.Green;
                tsk.taskEnable(taskOnOff);
            }
            else
            {
                ledTskOnOff.BackColor = Color.Red;
                tsk.taskEnable(taskOnOff);
            }
        }
    }
}
