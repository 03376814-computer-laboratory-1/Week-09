using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Draw  circle
            Rectangle rect = new Rectangle(10, 10, 100, 100);
            g.DrawEllipse(Pens.Purple, rect);



            //Fill Circle
            Rectangle rect1 = new Rectangle(10, 120, 100, 100);
            g.FillEllipse(Brushes.DeepPink, rect1);



            //Draw ellispe
            Rectangle rect2 = new Rectangle(150, 10, 120, 100);
            g.DrawEllipse(Pens.DarkSlateBlue, rect2);


            //Fill ellipse
            Rectangle rect3 = new Rectangle(150, 120, 120, 100);
            g.FillEllipse(Brushes.Firebrick, rect3);

       
            g.Dispose();


        }

    }
}
