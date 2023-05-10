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
    public partial class Frm_HW09_OXGame : Form
    {
        public Frm_HW09_OXGame()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        int count = 0;
        int[,] arrBtn = new int[3, 3];

        void check()
        {
            count++;
            for (int x = 0; x < arrBtn.GetLength(0); x++)
            {
                if (arrBtn[x, 0] == arrBtn[x, 1] && arrBtn[x, 1] == arrBtn[x, 2] && arrBtn[x, 0] != 0 && arrBtn[x, 1] != 0 && arrBtn[x, 2] != 0)
                    GameOver(arrBtn[x, 0]);
            }
            for (int y = 0; y < arrBtn.GetLength(0); y++)
            {
                if (arrBtn[0, y] == arrBtn[1, y] && arrBtn[1, y] == arrBtn[2, y] && arrBtn[0, y] != 0 && arrBtn[1, y] != 0 && arrBtn[2, y] != 0)
                    GameOver(arrBtn[0, y]);
            }
            if (arrBtn[0, 0] == arrBtn[1, 1] && arrBtn[1, 1] == arrBtn[2, 2] && arrBtn[0, 0] != 0 && arrBtn[1, 1] != 0 && arrBtn[2, 2] != 0)
                GameOver(arrBtn[0, 0]);
            if (arrBtn[2, 0] == arrBtn[1, 1] && arrBtn[1, 1] == arrBtn[0, 2] && arrBtn[2, 0] != 0 && arrBtn[1, 1] != 0 && arrBtn[0, 2] != 0)
                GameOver(arrBtn[2, 0]);
            if (count == 9)
                GameOver(3);
        }

        void GameOver(int check)
        {
            if (check == 1)
            {
                MessageBox.Show("X手獲勝!", "完局!");
                reset();
            }
            else if (check == 2)
            {
                MessageBox.Show("O手獲勝!", "完局!");
                reset();
            }
            else
            {
                MessageBox.Show("平手! 按下確定重新開始", "完局!");
                reset();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn1.Text = "X";
                arrBtn[0, 0] = 1;
            }
            else
            {
                btn1.Text = "O";
                arrBtn[0, 0] = 2;
            }
            check();

            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn2.Text = "X";
                arrBtn[1, 0] = 1;
            }
            else
            {
                btn2.Text = "O";
                arrBtn[1, 0] = 2;
            }
            check();

            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn3.Text = "X";
                arrBtn[2, 0] = 1;
            }
            else
            {
                btn3.Text = "O";
                arrBtn[2, 0] = 2;
            }
            check();

            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn4.Text = "X";
                arrBtn[0, 1] = 1;
            }
            else
            {
                btn4.Text = "O";
                arrBtn[0, 1] = 2;
            }
            check();

            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn5.Text = "X";
                arrBtn[1, 1] = 1;
            }
            else
            {
                btn5.Text = "O";
                arrBtn[1, 1] = 2;
            }
            check();

            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn6.Text = "X";
                arrBtn[2, 1] = 1;
            }
            else
            {
                btn6.Text = "O";
                arrBtn[2, 1] = 2;
            }
            check();

            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn7.Text = "X";
                arrBtn[0, 2] = 1;
            }
            else
            {
                btn7.Text = "O";
                arrBtn[0, 2] = 2;
            }
            check();

            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn8.Text = "X";
                arrBtn[1, 2] = 1;
            }
            else
            {
                btn8.Text = "O";
                arrBtn[1, 2] = 2;
            }
            check();

            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btn9.Text = "X";
                arrBtn[2, 2] = 1;
            }
            else
            {
                btn9.Text = "O";
                arrBtn[2, 2] = 2;
            }
            check();

            btn9.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "";
                    item.Enabled = true;
                }
            }
            btnReset.Text = "Reset(R)";
            btnExit.Text = "Exit(Esc)";
            count = 0;
            Array.Clear(arrBtn, 0, 9);
        }

        private void Frm_HW09_OXGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                reset();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
