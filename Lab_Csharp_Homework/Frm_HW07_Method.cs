using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW07_Method : Form
    {
        public Frm_HW07_Method()
        {
            InitializeComponent();
        }

        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            int Num = 0;
            bool result = int.TryParse(txtNumber.Text, out Num);

            if(result == false)
            {
                MessageBox.Show("請輸入整數。");
                return;
            }

            int EvenOrOdd = Num % 2;

            if(EvenOrOdd == 0) 
            {
                labResult.Text = $"輸入的數 {Num} 為「偶數」";
            }
            else
            {
                labResult.Text = $"輸入的數 {Num} 為「奇數」";
            }
        }

        int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711Str = new string[] { "mother張", "emma", "迪克蕭", "J40"
            , "Candy", "Cindy", "Coconut", "Motherfacker" };

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            labResult.Text = $"陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                $"最大值為 { arr0711.Max()} \n最小值為 {arr0711.Min()} ";
        }

        private void btnArrEvenOdd_Click(object sender, EventArgs e)
        {

            int count = 0;

            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    count++;
                }
            }

            labResult.Text = $"陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + 
                $"偶數共 {count} 個\n奇數共 {arr0711.Length - count} 個";
        }


        private void btnMax_Click(object sender, EventArgs e)
        {
            labResult.Text = $"陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                $"最大值為 {arr0711.Max()}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labResult.Text = $"陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                $"最小值為 {arr0711.Min()}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            labResult.Text = $"陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + 
                $"加總為 {arr0711.Sum()}";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            int lenMax = arr0711Str[0].Length;
        for(int i = 0; i < arr0711Str.Length;i++)
            {
                if (arr0711Str[i].Length > lenMax)
                {
                    lenMax = arr0711Str[i].Length;
                }
                if (arr0711Str[i].Length == lenMax)
                {
                    labResult.Text = $"陣列arr0711Str中\n最長的名字為{arr0711Str[i]}";
                }
            }
        }

        private void btnFindC_Click(object sender, EventArgs e)
        {
            int resultUp = 0, resultLow = 0, resultBoth=0;
            for (int i = 0; i < arr0711Str.Length; i++)
            {
                bool searchUp = arr0711Str[i].Contains("C");
                    if (searchUp)
                {
                    resultUp++;
                }
                bool searchLow = arr0711Str[i].Contains("c");
                if (searchLow)
                {
                    resultLow++;
                }
                if(searchUp && searchLow)
                {
                    resultBoth--;
                }
            }

                labResult.Text = $"陣列arr0711Str中\n有C或c的名字共有{resultUp + resultLow + resultBoth}個";

        }

        private void btnArrFrame_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string result = "";
            for (int i = 0, j=0; i < arr.GetLength(0) || j<arr.GetLength(1); i++, j++)
            {
                arr[i, 0] = 1;
                arr[i, 9] = 1;
                arr[0, j] = 1;
                arr[9, j] = 1;
            }

            for (int i=0; i < arr.GetLength(0); i++)
            {
                for(int j =0; j < arr.GetLength(1); j++)
                {
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnArrInside_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string result = "";
            for (int i = 1; i < (arr.GetLength(0)-1); i++)
            {
                for (int j = 1; j < (arr.GetLength(1) - 1); j++)
                    arr[i, j] = 1;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnArrOddEven_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];
            string result = "";

            for(int i=0;  i < arr.GetLength(0);)
            {
                for (int j = 0; j < arr.GetLength(1);)
                {
                    arr[i, j] = 1;
                    j += 2;
                }
                i += 2;
            }
            for (int i = 1; i < arr.GetLength(0);)
            {
                for (int j = 1; j < arr.GetLength(1);)
                {
                    arr[i, j] = 1;
                    j += 2;
                }
                i += 2;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += $"{arr[i, j]} ";
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int total = 0;
            
            if (string.IsNullOrEmpty(txtFrom.Text)|| string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            bool FromIsNum = int.TryParse(txtFrom.Text, out int from);
            bool ToIsNum= int.TryParse(txtTo.Text, out int to);
            bool StepIsNum = int.TryParse(txtStep.Text, out int step);
            if (!FromIsNum || !ToIsNum || !StepIsNum)
            {
                MessageBox.Show("請輸入整數。");
                txtFrom.SelectAll();
                txtFrom.Focus();
            }
            else
            {
                for (int i = from; i <= to;)
                {
                    total += i;
                    i += step;
                }
                labResult.Text = $"{from} 到 {to} 相隔 {step-1} \n加總為 {total}";
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            bool FromIsNum = int.TryParse(txtFrom.Text, out int from);
            bool ToIsNum = int.TryParse(txtTo.Text, out int to);
            bool StepIsNum = int.TryParse(txtStep.Text, out int step);
            if (!FromIsNum || !ToIsNum || !StepIsNum)
            {
                MessageBox.Show("請輸入整數。");
                txtFrom.SelectAll();
                txtFrom.Focus();
            }
            else
            {
                int i = from;
                do
                {
                    total += i;
                    i += step;
                } while (i <= to);
                labResult.Text = $"{from} 到 {to} 相隔 {step - 1} \n加總為 {total}";
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值。");
                return;
            }

            bool FromIsNum = int.TryParse(txtFrom.Text, out int from);
            bool ToIsNum = int.TryParse(txtTo.Text, out int to);
            bool StepIsNum = int.TryParse(txtStep.Text, out int step);
            if (!FromIsNum || !ToIsNum || !StepIsNum)
            {
                MessageBox.Show("請輸入整數。");
                txtFrom.SelectAll();
                txtFrom.Focus();
            }
            else
            {
                int i = from;
                while(i <= to)
                {
                    total += i;
                    i += step;
                }
                labResult.Text = $"{from} 到 {to} 相隔 {step - 1} \n加總為 {total}";
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRows.Text))
            {
                MessageBox.Show("請輸入數值。");
                txtRows.Clear();
                txtRows.Focus();
                return;
            }

            bool IsNum = int.TryParse(txtRows.Text, out int row);
            if (IsNum)
            {
                labResult.Text = "";
                for (int i = 0; i < row; i++)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        labResult.Text += "*";
                    }
                  labResult.Text += "\n";
                }

            }
            else
            {
                MessageBox.Show("請輸入整數。");
                txtRows.Clear();
                txtRows.Focus();
            }

        }

        private void btn99Table_Click(object sender, EventArgs e)
        {
            labResult.Text = "九九乘法表\n";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    labResult.Text += $"{j}x{i}={j*i} | ";
                }
                labResult.Text += "\n";
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            //labResult.Text = Convert.ToString(100, 2)+"\n";
            labResult.Text = "";
            int i = 100;
            string bin = "";

            while (i >= 2)
            {
                if(i%2 == 0)
                {
                    bin+= "0";
                }
                if(i%2 == 1)
                {
                    bin += "1";
                }
                i /= 2;
            }  ;

            bin += i.ToString();

            for (int j = (bin.Length) - 1; j >= 0; j--)
            { 
                labResult.Text += bin[j]; 
            }
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int[] lottoArr = new int[6];

            labResult.Text = $"樂透號碼\n";

            for (int i = 0;i < 6; i++)
            {
                lottoArr[i] = rd.Next(1, 49);
                for (int j = 0; j < i; j++)
                {
                    while (lottoArr[j] == lottoArr[i])
                    {
                        j = 0;
                        lottoArr[i] = rd.Next(1, 49);
                    }
                }
                labResult.Text += lottoArr[i] + "  ";
            }

        }
    }
}
