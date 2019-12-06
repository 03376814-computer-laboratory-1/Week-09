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
            GraphicsPath gpath = new GraphicsPath();
            gpath.AddEllipse(46, 4, 28, 28);
            gpath.AddLine(36, 32, 84, 32);
            gpath.AddLine(100, 80, 88, 84);
            gpath.AddLine(76, 50, 74, 84);
            gpath.AddLine(90, 150, 74, 150);
            gpath.AddLine(60, 100, 46, 150);
            gpath.AddLine(32, 150, 46, 84);
            gpath.AddLine(44, 50, 32, 84);
            gpath.AddLine(20, 80, 36, 32);
            g.FillPath(Brushes.Blue, gpath);
            g.Dispose();





        }

    }
}
