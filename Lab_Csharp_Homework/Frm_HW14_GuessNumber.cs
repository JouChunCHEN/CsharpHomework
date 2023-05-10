using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW14_GuessNumber : Form
    {
        public Frm_HW14_GuessNumber()
        {
            InitializeComponent();
            labHint.Text = "Please Select A Number Between 1 to 100!";
        }

            Frm_HW14_Guess frm = new Frm_HW14_Guess();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                frm.Show();
            }
            catch(ObjectDisposedException ex)
            {
                MessageBox.Show($"請關閉視窗重新開啟\n" +
                    $"----------------------\n{ex.Message}","錯誤!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"請關閉視窗重新開啟\n" +
                    $"----------------------\n{ex.Message}", "錯誤!!!");
            }

            timer1.Enabled = true;
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: "+frm.GetAns());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labHint.Text = frm.GetHint();
        }
    }
}
