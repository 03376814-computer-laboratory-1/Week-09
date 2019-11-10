using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Point[] body =
            {
                new Point(23,263),
                //new Point(40,120),
                new Point(48,99),
                new Point(66,36),
                new Point(92,20),
                new Point(126,35),
                //new Point(48,132),
                new Point(140,99),
                //new Point(146,120),
                new Point(167,263)
            };
            Rectangle face = new Rectangle(64, 33, 61, 93);
            Point[] eyebrowR =
            {
                new Point(71,65),
                new Point(77,51),
                new Point(80,65)
            };
            Point[] eyebrowL =
            {
                new Point(108,65),
                new Point(114,51),
                new Point(117,65)
            };
            Rectangle eyeR = new Rectangle(69, 70, 13, 10);
            Rectangle eyeL = new Rectangle(106, 70, 13, 10);
            Rectangle UnderEyeR = new Rectangle(71, 81, 10, 2);
            Rectangle UnderEyeL = new Rectangle(108, 81, 10, 2);
            Point[] tattooR =
            {
                new Point(70,87),
                new Point(75,104),
                new Point(80,87)
            };
            Point[] tattooL =
            {
                new Point(109,87),
                new Point(114,104),
                new Point(119,87)
            };
            Rectangle mouth = new Rectangle(85, 110, 20, 5);
            Rectangle tattooMouth = new Rectangle(88, 117, 15, 3);
            g.FillClosedCurve(Brushes.Black, body);
            g.FillEllipse(Brushes.OldLace, face);
            g.FillClosedCurve(Brushes.Thistle, eyebrowR);
            g.FillClosedCurve(Brushes.Thistle, eyebrowL);
            g.FillEllipse(Brushes.Black, eyeR);
            g.FillEllipse(Brushes.Black, eyeL);
            g.FillEllipse(Brushes.Black, UnderEyeR);
            g.FillEllipse(Brushes.Black, UnderEyeL);
            g.FillClosedCurve(Brushes.Thistle, tattooR);
            g.FillClosedCurve(Brushes.Thistle, tattooL);
            g.FillEllipse(Brushes.Black, mouth);
            g.FillEllipse(Brushes.Thistle, tattooMouth);

            g.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }
    }
}
