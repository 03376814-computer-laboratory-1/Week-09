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
            Pen myPen = new Pen(Color.Blue, 3);
            g.DrawRectangle(myPen, 10, 120, 100, 100);

            Rectangle rect = new Rectangle(10, 10, 100, 100);
            g.DrawRectangle(myPen, rect);
            g.Dispose();
        }
    }
}
