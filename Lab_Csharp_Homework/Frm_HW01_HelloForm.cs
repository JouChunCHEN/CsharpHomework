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
    public partial class Frm_HW01_HelloForm : Form
    {
        public Frm_HW01_HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Gender = txtGender.Text;
            string Star = txtStar.Text;
            MessageBox.Show("Hello， 我是" + Name + "，" 
                + "\n我的英文名字是" + EngName + "，" 
                + "\n性別是" + Gender + "，" 
                + "\n星座是" + Star + "，" 
                + "\n很高興認識你！" );
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Gender = txtGender.Text;
            string Star = txtStar.Text;
            MessageBox.Show("Hello， 我是" + Name + "，"
                + "\n我的英文名字是" + EngName + "，"
                + "\n性別是" + Gender + "，"
                + "\n星座是" + Star + "，"
                + "\n很高興認識你！");
        }
    }
}
