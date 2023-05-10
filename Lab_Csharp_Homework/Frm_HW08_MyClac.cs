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
    public partial class Frm_HW08_MyClac : Form
    {
        public Frm_HW08_MyClac()
        {
            InitializeComponent();
        }

        double num1, num2;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text) || string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            labAnswer.Text =(num1+num2).ToString();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            labAnswer.Text = (num1 - num2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            labAnswer.Text = (num1 * num2).ToString();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            labAnswer.Text = (num1 / num2).ToString();
        }


    }
}
