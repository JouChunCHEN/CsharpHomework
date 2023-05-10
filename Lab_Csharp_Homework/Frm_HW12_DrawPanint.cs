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
    public partial class Frm_HW12_DrawPanint : Form
    {
        Graphics g;
        Pen pen;
        int x = -1, y = -1;
        bool moving = false;
        public Frm_HW12_DrawPanint()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(picColor.BackColor, 1);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                picColor.BackColor = dlg.Color;
                pen.Color = dlg.Color;
            }
        }

        private void trackBarBrush_Scroll(object sender, EventArgs e)
        {
            labBar.Text = trackBarBrush.Value.ToString();
            pen.Width = trackBarBrush.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y= e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving= false;
            x = -1;
            y = -1;
        }
    }
}
