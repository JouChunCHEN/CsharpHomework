using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Csharp_Homework
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnOpenHW01_Click(object sender, EventArgs e)
        {
            Frm_HW01_HelloForm frmHW01 = new Frm_HW01_HelloForm();
            frmHW01.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW01);
            frmHW01.Show();
        }

        private void btnOpenWH02_Click(object sender, EventArgs e)
        {
            Frm_HW02_LoanForm frmHW02 = new Frm_HW02_LoanForm();
            frmHW02.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW02); 
            frmHW02.Show();
        }

        private void btnOpenWH03_Click(object sender, EventArgs e)
        {
            Frm_HW03_POS frmHW03 = new Frm_HW03_POS();
            frmHW03.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW03);
            frmHW03.Show();
        }

        private void btnOpenMH04_Click(object sender, EventArgs e)
        {
            Frm_HW04_StructForm frmHW04 = new Frm_HW04_StructForm();
            frmHW04.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW04);
            frmHW04.Show();
        }

        private void btnOpenMyClac_Click(object sender, EventArgs e)
        {
            Frm_HW08_MyClac frmHW08 = new Frm_HW08_MyClac();
            frmHW08.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW08); 
            frmHW08.Show();
        }

        private void btnOpenMethod_Click(object sender, EventArgs e)
        {
            Frm_HW07_Method frmHW07 = new Frm_HW07_Method();
            frmHW07.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW07);
            frmHW07.Show();
        }

        private void btnOpenHW05_Click(object sender, EventArgs e)
        {
            Frm_HW05_StudentsGrade frmHW05 = new Frm_HW05_StudentsGrade(); 
            frmHW05.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW05);
            frmHW05.Show();
        }

        private void btnOpenHW06_Click(object sender, EventArgs e)
        {
            Frm_HW06_StudentGrade_List frmHW06 = new Frm_HW06_StudentGrade_List();
            frmHW06.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW06);
            frmHW06.Show();
        }

        private void btnOpenHW09_Click(object sender, EventArgs e)
        {
            Frm_HW09_OXGame frmHW09 = new Frm_HW09_OXGame();
            frmHW09.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW09);
            frmHW09.Show();
        }

        private void btnOpenWH11_Click(object sender, EventArgs e)
        {
            Frm_HW11_Notepad frmHW11 = new Frm_HW11_Notepad();
            frmHW11.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW11);
            frmHW11.Show();
        }

        private void btnOpenHW12_Click(object sender, EventArgs e)
        {
            Frm_HW12_DrawPanint frmHW12 = new Frm_HW12_DrawPanint();
            frmHW12.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW12);
            frmHW12.Show();
        }

        private void btnOpenHW10_Click(object sender, EventArgs e)
        {
            Frm_HW10_ScreenSaver frmHW10 = new Frm_HW10_ScreenSaver();
            frmHW10.Show();
        }

        private void btnOpenAlarm_Click(object sender, EventArgs e)
        {
            Frm_HW15_Alarm frmHW15 = new Frm_HW15_Alarm();
            frmHW15.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW15);
            frmHW15.Show();
        }

        private void btnOpenHW13_Click(object sender, EventArgs e)
        {
            Frm_HW13_PictureViewer frmHW13 = new Frm_HW13_PictureViewer();
            frmHW13.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW13);
            frmHW13.Show();
        }

        private void btnOpenHW14_Click(object sender, EventArgs e)
        {
            Frm_HW14_GuessNumber frmHW14 = new Frm_HW14_GuessNumber();
            frmHW14.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frmHW14);
            frmHW14.Show();
        }


    }
}
