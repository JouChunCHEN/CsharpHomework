using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW15_Alarm : Form
    {
        public Frm_HW15_Alarm()
        {
            InitializeComponent();
        }

        bool Alarm = false;
        bool Attention = false;
        DateTime nowTime, setTime;

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("es-ES"));
            nowTime = DateTime.Now;
            TimeSpan ts = setTime - nowTime;

            if (Alarm && ts.TotalSeconds<0)
            {
                this.BackColor = Color.Red;
                if (Attention)
                {
                    this.BackColor = Color.Red;
                }
                else if (!Attention)
                {
                    this.BackColor = Color.Black;
                    foreach (Control item in Controls)
                    {
                        if (item is CheckBox)
                            continue;
                        item.ForeColor = Color.White;
                    }
                }
            }
            else if (!Alarm)
            {
                this.BackColor = SystemColors.Window;
                foreach (Control item in Controls)
                {
                    item.ForeColor = SystemColors.ControlText;
                }
            }

            Attention = !Attention;
        }

        private void checkSet_CheckedChanged(object sender, EventArgs e)
        {
            if (txtAlarmTime.Text=="  時  分  秒")
            {
                MessageBox.Show("請輸入數值。");
                return;
            }
            Alarm = !Alarm;
            setTime = DateTime.Parse(txtAlarmTime.Text);
        }
    }
}
