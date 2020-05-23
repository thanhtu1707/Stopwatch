using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTime
{
    public partial class RunTime: UserControl
    {
        public RunTime()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = txtTime.Text;
            string[] time1 = time.Split(':');
            int gio = int.Parse(time1[0]);
            int phut = int.Parse(time1[1]);
            int giay = int.Parse(time1[2]);
            giay--;
            if (giay == 0)
            {
                phut--;
                if (phut == 0)
                {
                    gio--;
                    if (gio == 0)
                    {
                        timer1.Stop();
                        txtTime.Text = "00:00:00";
                    }
                }
            }
            
            
        }
    }
}
