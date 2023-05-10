using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW04_StructForm : Form
    {
        public Frm_HW04_StructForm()
        {
            InitializeComponent();
        }

        string result = "姓名：" + "\n國文：0分" + "\n英文：0分" + "\n數學：0分";

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            ScoreData sd = new ScoreData(txtName.Text, int.Parse(txtChi.Text)
                , int.Parse(txtEng.Text), int.Parse(txtMath.Text));
            sd.Name = txtName.Text;
            result = "姓名：" + sd.Name  + "\n國文：" + sd.ChiScore + "分" 
                + "\n英文：" + sd.EngScore + "分" + "\n數學：" + sd.MathScore +"分";
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            labDataList.Text = result;
        }

        string SubjectMax;
        string SubjectMin;

        private void btnShowSubject_Click(object sender, EventArgs e)
        {
            int[] Scores = new int[3] { int.Parse(txtChi.Text), int.Parse(txtEng.Text), int.Parse(txtMath.Text) };

            if (Scores.Max()== int.Parse(txtChi.Text))
            {
                SubjectMax = "國文";
            }
            else if (Scores.Max() == int.Parse(txtEng.Text))
                {
                    SubjectMax = "英文";
                }
            else/*(Scores.Max() == int.Parse(txtMath.Text))*/
            {
                    SubjectMax = "數學";
                }

            if (Scores.Min() == int.Parse(txtChi.Text))
            {
                SubjectMin = "國文";
            }
            else if (Scores.Min() == int.Parse(txtEng.Text))
            {
                SubjectMin = "英文";
            }
            else /*(Scores.Min() == int.Parse(txtMath.Text))*/
            {
                SubjectMin = "數學";
            }

            labSubject.Text = "最高分科目成績為：" + SubjectMax + Scores.Max() + "分"
                + "\n最低分科目成績為：" + SubjectMin + Scores.Min() + "分";
            }
        }

    }
