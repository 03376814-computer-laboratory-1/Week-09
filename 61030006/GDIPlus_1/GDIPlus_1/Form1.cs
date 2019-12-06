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
            Point[] pt =
            {
                new Point(10,22),
            new Point(188, 246),
            new Point(250,192),
            new Point(220,48),
            };
            g.FillClosedCurve(Brushes.Blue, pt);
            g.DrawClosedCurve(Pens.Red, pt);
            g.Dispose();





        }

    }
}
