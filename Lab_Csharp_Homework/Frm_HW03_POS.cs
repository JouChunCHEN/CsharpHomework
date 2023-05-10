using System;
using System.Collections;
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
    public partial class Frm_HW03_POS : Form
    {
        public Frm_HW03_POS()
        {
            InitializeComponent();
        }

        int total = 0;
        int BeerCount = 0;
        int TequilaCount = 0;
        int WhiskyCount = 0;
        int WineCount = 0;

        string[] Order = new string[4];

        private void btnMenuBear_Click(object sender, EventArgs e)
        {
            total += 120;
            labTotalPrice.Text = "NT$ " + total;
            BeerCount++;
            Order[0] = "啤酒Beer x" + BeerCount + ",共NT$" + BeerCount * 120 + "元\n";
            labListShow.Text = Order[0] + Order[1]+ Order[2] + Order[3];
        }

        private void btnMenuTequila_Click(object sender, EventArgs e)
        {
            total += 180;
            labTotalPrice.Text = "NT$ " + total;
            TequilaCount++;
            Order[1] = "龍舌蘭Tequila x" + TequilaCount + ",共NT$" + TequilaCount * 180 + "元\n";
            labListShow.Text = Order[0] +  Order[1] + Order[2] + Order[3];
        }

        private void btnMenuWhisky_Click(object sender, EventArgs e)
        {
            total += 350;
            labTotalPrice.Text = "NT$ " + total;
            WhiskyCount++;
            Order[2] = "威士忌Whisky x" + WhiskyCount + ",共NT$" + WhiskyCount * 350 + "元\n";
            labListShow.Text = Order[0] + Order[1]+Order[2] + Order[3];
        }

        private void btnMenuWine_Click(object sender, EventArgs e)
        {
            total += 320;
            labTotalPrice.Text = "NT$ " + total;
            WineCount++;
            Order[3] = "紅酒Wine x" + WineCount + ",共NT$" + WineCount * 320 + "元\n";
            labListShow.Text = Order[0] + Order[1]+ Order[2] + Order[3];
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐！", "確認金額", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("總金額：NT$ " + total, "確認金額");
        }

        private void btnPayCredit_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐！", "確認金額", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("總金額：NT$ " + total*0.9, "確認金額");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            BeerCount = 0;
            TequilaCount = 0;
            WhiskyCount = 0;
            WineCount = 0;
            Array.Clear(Order, 0, 4);
            labTotalPrice.Text = "NT$ " + total;
            labListShow.Text = "尚未點餐";
        }
    }
}
