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
            Pen pen = new Pen(Color.Green,2);
            Point[] pt = { new Point(20,200),new Point(50,20),
                           new Point(100,100),new Point(150,230),
                           new Point(200,200)};
            g.DrawCurve(pen, pt);
            g.Dispose();










        }

    }
}
