using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW14_Guess : Form
    {
        public Frm_HW14_Guess()
        {
            InitializeComponent();
            Hint = "Please Select A Number Between 1 to 100!";
            Random random = new Random();
            Answer = random.Next(1, 100);
        }

        int Answer;
        string Hint;
        public int GetAns()
        {
            return Answer;
        }

        public string GetHint()
        {
            return Hint;
        }

        int Max = 100;
        int Min = 1;

        private void btnGuess_Click(object sender, EventArgs e)
        {
            bool IsNum = int.TryParse(txtGuessNum.Text, out int Num);
            int Ans = Answer;

            if (IsNum)
            {
                if (Num == Ans)
                {
                    MessageBox.Show("恭喜猜對，答案是" + Ans);
                }
                else if (Num > Ans)
                {
                    Max = Num;
                    MessageBox.Show("太大了");
                    Hint = $"Too large.\nBetween {Min} and {Max}";
                }
                else if (Num < Ans)
                {
                    Min = Num;
                    MessageBox.Show("太小了");
                    Hint = $"Too small.\nBetween {Min} and {Max}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
                txtGuessNum.Clear();
                txtGuessNum.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
