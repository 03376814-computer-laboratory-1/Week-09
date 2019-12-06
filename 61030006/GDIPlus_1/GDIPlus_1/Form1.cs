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
            Pen[] objpen = new Pen[11];
            for (int i = 0; i < 11; i++)
            {
                objpen[i] = new Pen(Color.Blue, 9);
            }

            //set pen styles
            objpen[0].EndCap = LineCap.AnchorMask;
            objpen[1].EndCap = LineCap.ArrowAnchor;
            objpen[2].EndCap = LineCap.Custom;
            objpen[3].EndCap = LineCap.DiamondAnchor;
            objpen[4].EndCap = LineCap.Flat;
            objpen[5].EndCap = LineCap.NoAnchor;
            objpen[6].EndCap = LineCap.Round;
            objpen[7].EndCap = LineCap.RoundAnchor;
            objpen[8].EndCap = LineCap.Square;
            objpen[9].EndCap = LineCap.SquareAnchor;
            objpen[10].EndCap = LineCap.Triangle;

            for (int i = 0; i < 11; i++)
            {
                g.DrawLine(objpen[i], 10, 10 + 20 * i, 200, 10 + 20 * i);
                objpen[i].Dispose();

            }
            g.Dispose();










        }

    }
}
