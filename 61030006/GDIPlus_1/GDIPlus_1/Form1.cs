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

            Pen penEllipse = new Pen(Color.Brown);
            penEllipse.DashStyle = DashStyle.Dash;
            g.DrawEllipse(penEllipse, 20, 20, 200, 150);


            Pen penArc = new Pen(Color.Magenta, 2);
            g.DrawArc(penArc, 20, 20, 200, 150, 90, 180);

            g.Dispose();


        }

    }
}
