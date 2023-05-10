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
    public partial class Frm_HW05_StudentsGrade : Form
    {
        public Frm_HW05_StudentsGrade()
        {
            InitializeComponent();
        }

        public void ScoreClac(int ChiScore, int EngScore, int MathScore, out decimal total, out decimal averge, out string max, out string min)
        {
            total = ChiScore + EngScore + MathScore;
            averge = total / 3;
            
            int[] Scores = new int[3] { ChiScore, EngScore, MathScore };
            string SubjectMax, SubjectMin;

            if (Scores.Max() == ChiScore)
                SubjectMax = "國文";
            else if (Scores.Max() == EngScore)
                SubjectMax = "英文";
            else
                SubjectMax = "數學";

            if (Scores.Min() == ChiScore)
                SubjectMin = "國文";
            else if (Scores.Min() == EngScore)
                SubjectMin = "英文";
            else
                SubjectMin = "數學";

            max = SubjectMax + Scores.Max();
            min = SubjectMin + Scores.Min();
        }

        public void ShowData()
        {
            labGrade.Text = "";
            foreach (Student stu in lsStu)
            {
                labGrade.Text += $"{stu.Name}       {stu.ChiScore}       {stu.EngScore}       {stu.MathScore}       " +
                    $"{stu.Total}       {(stu.Averge):N2}       {stu.Min}       {stu.Max}\n";
            }
        }

        int count = 0;
        ArrayList lsStu = new ArrayList();
        Student stu;

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtChi.Text, out int ChiScore) && int.TryParse(txtEng.Text, out int EngScore) && int.TryParse(txtMath.Text, out int MathScore))
            {
                count++;
                stu.Name = txtName.Text;
                stu.ChiScore = ChiScore;
                stu.EngScore = EngScore;
                stu.MathScore = MathScore;
                ScoreClac(stu.ChiScore, stu.EngScore, stu.MathScore
                    , out decimal total, out decimal averge, out string max, out string min);
                stu.Total = total;
                stu.Averge = averge;
                stu.Max = max;
                stu.Min = min;

                lsStu.Add(stu);
                ShowData();

                btnResult.Enabled = true;
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

        private void btnRandomSave_Click(object sender, EventArgs e)
        {
            count++;
            Student stu;
            Random rd = new Random();
            stu.Name =count.ToString();
            stu.ChiScore = rd.Next(0, 100);
            stu.EngScore = rd.Next(0, 100);
            stu.MathScore = rd.Next(0, 100);
            ScoreClac(stu.ChiScore, stu.EngScore, stu.MathScore
                , out decimal total, out decimal averge, out string max, out string min);
            stu.Total = total;
            stu.Averge = averge;
            stu.Max = max;
            stu.Min = min;

            lsStu.Add(stu);
            ShowData();

            btnResult.Enabled = true;
        }

        private void btnRandomSave20_Click(object sender, EventArgs e)
        {
            int j = -1;
            for (int i = 0; i <20; i++, j++)
            {
                count++;
                Student stu;
                Random rd = new Random(Guid.NewGuid().GetHashCode()); //todo
                stu.Name = count.ToString();
                stu.ChiScore = rd.Next(0, 100);
                stu.EngScore = rd.Next(0, 100);
                stu.MathScore = rd.Next(0, 100);
                ScoreClac(stu.ChiScore, stu.EngScore, stu.MathScore
                    , out decimal total, out decimal averge, out string max, out string min);
                stu.Total = total;
                stu.Averge = averge;
                stu.Max = max;
                stu.Min = min;
                lsStu.Add(stu);
            }

            ShowData();
            btnResult.Enabled = true;
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

            int ChiMin = ((Student)lsStu[0]).ChiScore;
            int ChiMax = ((Student)lsStu[0]).ChiScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (((Student)lsStu[i]).ChiScore > ChiMax)
                    ChiMax = ((Student)lsStu[i]).ChiScore;
                if (((Student)lsStu[i]).ChiScore < ChiMin)
                    ChiMin = ((Student)lsStu[i]).ChiScore;
            }

            int EngMin = ((Student)lsStu[0]).EngScore;
            int EngMax = ((Student)lsStu[0]).EngScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (((Student)lsStu[i]).EngScore > EngMax)
                    EngMax = ((Student)lsStu[i]).EngScore;
                if (((Student)lsStu[i]).EngScore < EngMin)
                    EngMin = ((Student)lsStu[i]).EngScore;
            }

            int MathMin = ((Student)lsStu[0]).MathScore;
            int MathMax = ((Student)lsStu[0]).MathScore;
            for (int i = 0; i < lsStu.Count; i++)
            {
                if (((Student)lsStu[i]).MathScore > MathMax)
                    MathMax = ((Student)lsStu[i]).MathScore;
                if (((Student)lsStu[i]).MathScore < MathMin)
                    MathMin = ((Student)lsStu[i]).MathScore;
            }

            labResult.Text = "";
            labResult.Text += $"總分   {TotalChi}     {TotalEng}       {TotalMath}\n" +
                $"平均   {(TotalChi/lsStu.Count):N1}     {(TotalEng / lsStu.Count):N1}     {(TotalMath / lsStu.Count):N1}\n" +
                $"最高分 {ChiMax}       {EngMax}       {MathMax}\n" +
                $"最低分 {ChiMin}       {EngMin}       {MathMin}\n";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lsStu.Clear();
            ShowData();
            labResult.Text = "";
            count = 0;
            btnResult.Enabled = false;
        }

    }
}
