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
    public partial class Frm_HW02_LoanForm : Form
    {
        public Frm_HW02_LoanForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoan.Text))
            {
                MessageBox.Show("請輸入貸款金額");
                txtLoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                MessageBox.Show("請輸入年利率");
                txtRate.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPeriod.Text))
            {
                MessageBox.Show("請輸入貸款期數");
                txtPeriod.Focus();
                return;
            }

            if (double.TryParse(txtRate.Text, out double Rate) && double.TryParse(txtPeriod.Text, out double Period) && int.TryParse(txtLoan.Text, out int Loan))
            {
                MessageBox.Show("每月應支付" + MonthPay(Loan, Rate, Period) + "元"
                    + "\n總繳款為" + AmountPay(Loan, Rate, Period) + "元"
                    + "\n總繳利息為" + InterestPay(Loan, Rate, Period) + "元");
            }
            else
            {
                MessageBox.Show("請輸入數值。");
                txtRate.Clear();
                txtPeriod.Clear();
                txtLoan.Clear();
                txtLoan.Focus();
            }

    }

        //計算每月應繳金額
        public double MonthPay(double Loan, double Rate, double Period)
        {
            double RateMonth = Rate / 12 / 100; //月利率
            double Month = Period * 12; // 月數
            double MonthRatePay =
                (Math.Pow((1 + RateMonth), Month) * RateMonth)
                / (Math.Pow((1 + RateMonth), Month) - 1);
            //平均攤還率={[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            double MonthPayClac = Loan * MonthRatePay;
            //每月應繳金額 = 本金*平均攤還率
            return (int)MonthPayClac;
        }

        //計算總繳款
        public double AmountPay(double Loan, double Rate, double Period)
        {
            double Amount = MonthPay(Loan, Rate, Period) * Period * 12;
            //總付款 = 每月應繳金額*月期
            return (int)Amount;
        }

        //計算總利息
        public double InterestPay(double Loan, double Rate, double Period)
        {
            double InterestPayClac = AmountPay(Loan, Rate, Period) - Loan;
            //每期本息繳款*總期數 - 貸款金額
            return (int)InterestPayClac;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoan.Clear();
            txtRate.Clear();
            txtPeriod.Clear();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRate.Text, out double Rate) && double.TryParse(txtPeriod.Text, out double Period) && int.TryParse(txtLoan.Text, out int Loan))
            {
                Frm_HW02_LoanFormReport frm = new Frm_HW02_LoanFormReport();
                frm.labLoanReport.Text = this.txtLoan.Text;
                frm.labRateReport.Text = this.txtRate.Text;
                frm.labPeriodReport.Text = this.txtPeriod.Text;

                frm.labMonthPayReport.Text = MonthPay(Loan, Rate, Period).ToString();
                frm.labAmontPayReport.Text = AmountPay(Loan, Rate, Period).ToString();
                frm.labInterestReport.Text = InterestPay(Loan, Rate, Period).ToString();

                frm.Show();
            }
            else
            {
                MessageBox.Show("請輸入數值。");
                txtRate.Clear();
                txtPeriod.Clear();
                txtLoan.Clear();
                txtLoan.Focus();
            }
        }
    }
    }

