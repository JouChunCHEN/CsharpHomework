using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW02_LoanFormReport : Form
    {
        public Frm_HW02_LoanFormReport()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("LoanReport.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default); //Default預設為ANSI(每台電腦設定不一樣)
            sw.Write($"貸款金額：{labLoanReport.Text}\n年利率：{labRateReport.Text}%\n期數：{labRateReport.Text}年\n" +
                $"月付款：{labMonthPayReport.Text}\n總繳款：{labAmontPayReport.Text}\n總利息：{labInterestReport.Text}");
            sw.Close();
            fs.Close();

            MessageBox.Show("檔案LoanReport.txt已儲存");

        }
    }
}
