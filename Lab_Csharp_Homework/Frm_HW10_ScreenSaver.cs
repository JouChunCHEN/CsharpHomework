using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab_Csharp_Homework
{
    public partial class Frm_HW10_ScreenSaver : Form
    {
        public Frm_HW10_ScreenSaver()
        {
            InitializeComponent();
            Random rnd = new Random();
            stepX = rnd.Next(5, 15);
            stepY = rnd.Next(5, 15);
        }

        int stepX, stepY;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((picCat.Location.X + picCat.Width) > Bounds.Width || picCat.Location.X< 0)
            {
                stepX = 0 - stepX;
            }

            if((picCat.Location.Y+ picCat.Height) > Bounds.Height || picCat.Location.Y < 0)
            {
                stepY = 0 - stepY;
            }

            picCat.Location = new Point(picCat.Location.X + stepX, picCat.Location.Y + stepY);

        }

        private void Frm_HW10_ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        Point mouseLocation;

        private void Frm_HW10_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                if ((mouseLocation.X - e.X) > 5  || (mouseLocation.Y - e.Y) > 5)
                    this.Close();
            }

            mouseLocation = e.Location;
        }

    }
}
