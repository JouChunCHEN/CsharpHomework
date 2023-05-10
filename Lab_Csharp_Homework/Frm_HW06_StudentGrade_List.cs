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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW06_StudentGrade_List : Form
    {
        public Frm_HW06_StudentGrade_List()
        {
            InitializeComponent();
        }

        Frm_HW05_StudentsGrade frmHW05 = new Frm_HW05_StudentsGrade();
        List<Student> lsStu = new List<Student>();
        Student stu;

        void ShowData()
        {
            labGrade.Text = "";
            foreach (Student stu in lsStu)
            {
                labGrade.Text += $"{stu.Name}       {stu.ChiScore}       {stu.EngScore}       {stu.MathScore}       " +
                    $"{stu.Total}       {(stu.Averge):N2}       {stu.Min}       {stu.Max}\n";
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtChi.Text, out int ChiScore) && int.TryParse(txtEng.Text, out int EngScore) && int.TryParse(txtMath.Text, out int MathScore))
            {
                stu.Name = txtName.Text;
                stu.ChiScore = ChiScore;
                stu.EngScore = EngScore;
                stu.MathScore = MathScore;
                frmHW05.ScoreClac(stu.ChiScore, stu.EngScore, stu.MathScore
                    , out decimal total, out decimal averge, out string max, out string min);
                stu.Total = total;
                stu.Averge = averge;
                stu.Max = max;
                stu.Min = min;

                lsStu.Add(stu);
                ShowData();
                btnResult.Enabled = true;
                btnRemoveData.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入數值。");
                txtChi.Clear();
                txtEng.Clear();
                txtMath.Clear();
                txtChi.Focus();
            }

        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtChi.Text, out int ChiScore) && int.TryParse(txtEng.Text, out int EngScore) && int.TryParse(txtMath.Text, out int MathScore))
            {
                stu.Name = txtName.Text;
                stu.ChiScore = ChiScore;
                stu.EngScore = EngScore;
                stu.MathScore = MathScore;
                frmHW05.ScoreClac(stu.ChiScore, stu.EngScore, stu.MathScore
                , out decimal total, out decimal averge, out string max, out string min);
                stu.Total = total;
                stu.Averge = averge;
                stu.Max = max;
                stu.Min = min;

                lsStu.Insert(0, stu);
                ShowData();
                btnResult.Enabled = true;
                btnRemoveData.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入數值。");
                txtChi.Clear();
                txtEng.Clear();
                txtMath.Clear();
                txtChi.Focus();
            }

        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            lsStu.RemoveAt(0);
            ShowData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lsStu.Clear();
            ShowData();
            labResult.Text = "";
            btnResult.Enabled = false;
            btnRemoveData.Enabled = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            decimal TotalChi = 0, TotalEng = 0, TotalMath = 0;
            foreach (Student stu in lsStu)
            {
                TotalChi += stu.ChiScore;
                TotalEng += stu.EngScore;
                TotalMath += stu.MathScore;
            }

            int ChiMin = lsStu[0].ChiScore;
            int ChiMax = lsStu[0].ChiScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (lsStu[i].ChiScore > ChiMax)
                    ChiMax = lsStu[i].ChiScore;
                if (lsStu[i].ChiScore < ChiMin)
                    ChiMin = lsStu[i].ChiScore;
            }

            int EngMin = lsStu[0].EngScore;
            int EngMax = lsStu[0].EngScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (lsStu[i].EngScore > EngMax)
                    EngMax = lsStu[i].EngScore;
                if (lsStu[i].EngScore < EngMin)
                    EngMin = lsStu[i].EngScore;
            }

            int MathMin = lsStu[0].MathScore;
            int MathMax = lsStu[0].MathScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (lsStu[i].MathScore > MathMax)
                    MathMax = lsStu[i].MathScore;
                if (lsStu[i].MathScore < MathMin)
                    MathMin = lsStu[i].MathScore;
            }

            labResult.Text = "";
            labResult.Text += $"總分   {TotalChi}     {TotalEng}       {TotalMath}\n" +
                $"平均   {(TotalChi / lsStu.Count):N1}     {(TotalEng / lsStu.Count):N1}     {(TotalMath / lsStu.Count):N1}\n" +
                $"最高分 {ChiMax}       {EngMax}       {MathMax}\n" +
                $"最低分 {ChiMin}       {EngMin}       {MathMin}\n";
        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            labGrade.Text = "";
            for (int i = 0; i < lsStu.Count; i++)
            {
                int SearchMin = int.Parse(txtSearchMin.Text);
                int SearchMax = int.Parse(txtSearchMax.Text);
                if (SearchMin <= lsStu[i].ChiScore && lsStu[i].ChiScore <= SearchMax)
                {
                    labGrade.Text += $"{lsStu[i].Name}       {lsStu[i].ChiScore}       {lsStu[i].EngScore}       " +
                    $"{lsStu[i].MathScore}       {lsStu[i].Total}       {lsStu[i].Averge:N2}       " +
                    $"{lsStu[i].Min}       {lsStu[i].Max}\n";
                }
            }
        }
    }
}
