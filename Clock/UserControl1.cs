using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clock
{
    public partial class UserControl1: UserControl
    {
        private DateTime start;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrBlock.Enabled = !tmrBlock.Enabled;
            btnStart.Text = tmrBlock.Enabled ? "Stop" : "Start";
            start = DateTime.Now;
        }

        private void tmrBlock_Tick(object sender, EventArgs e)
        {
            //trả về thời gian của ngày hiện tại
            TimeSpan times = DateTime.Now - start;//times=0
            string text = "";
            if (times.Days > 0)
            {
                text += times.Days.ToString()+".";
            }
            int tenths = times.Milliseconds;

            text +=
                times.Hours.ToString("00") + ":" +
                times.Minutes.ToString("00") + ":" +
                times.Seconds.ToString("00");

            lblTime.Text = text;
            lbl_milisecond.Text = tenths.ToString("000");
        }

        private void btnLap_Click(object sender, EventArgs e)
        {

            //Ghi file
            string filepath = "D:\\Thầy Danh\\NguyenThiThanhTu_2001170211_BTVN_Tuan03\\Time.txt";
            FileStream fs = new FileStream(filepath,FileMode.OpenOrCreate);
            string string1 = lblTime.Text +" "+ lbl_milisecond.Text;
            MessageBox.Show(string1);
            StreamWriter swriter = new StreamWriter(fs, Encoding.UTF8);
            swriter.WriteLine(string1);
            swriter.Flush();
            fs.Close();

        }
    }
}
