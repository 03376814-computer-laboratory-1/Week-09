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
            Pen mypen = new Pen(Color.Blue, 3);
            Rectangle[] rect =
            {
                new Rectangle(20,20, 120, 20),
                new Rectangle(20,50, 120, 30),
                new Rectangle(20,90, 120, 40),
                new Rectangle(20,140, 120, 60),
            };
            g.DrawRectangles(mypen, rect);

       
            g.Dispose();


        }

    }
}
