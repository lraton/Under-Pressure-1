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
        String msg = tsk.Split();
        public Form1()
        {
            serial.Text=msg;
            InitializeComponent();
        }

    }
}
