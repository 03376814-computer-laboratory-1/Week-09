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
            Pen blackpen = new Pen(Color.Black, 3);
            Point ponit1 = new Point(100, 100);
            Point ponit2 = new Point(200, 200);
            e.Graphics.DrawLine(blackpen, ponit1, ponit2);
            blackpen.Dispose();
           

        }
    }
}
