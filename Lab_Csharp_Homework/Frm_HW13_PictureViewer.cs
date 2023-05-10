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
    public partial class Frm_HW13_PictureViewer : Form
    {
        public Frm_HW13_PictureViewer()
        {
            InitializeComponent();
        }

        void PictureShow(PictureBox pb)
        {
            Form picShow = new Form();
            picShow.Show();
            picShow.BackgroundImage = pb.Image;
            picShow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureShow(pictureBox6);
        }
    }
}
