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
            Rectangle body = new Rectangle(20, 20,300, 250);
            g.FillEllipse(Brushes.White, body);

            Rectangle body1 = new Rectangle(80, 80, 300, 250);
            g.FillEllipse(Brushes.White, body1);


            Rectangle body2 = new Rectangle(200, 120, 120, 250);
            g.FillEllipse(Brushes.White, body2);

            Rectangle body3 = new Rectangle(80, 80, 220, 170);
            g.FillEllipse(Brushes.Yellow, body3);

            
            Rectangle eye1 = new Rectangle(135, 130, 30, 5);
            g.FillEllipse(Brushes.Black, eye1);

            Rectangle eye2 = new Rectangle(205, 130, 30, 5);
            g.FillEllipse(Brushes.Black, eye2);

            Rectangle mouth = new Rectangle(170, 150, 50, 10);
            g.FillEllipse(Brushes.White, mouth);

            Brush mouth1 = new SolidBrush(Color.Black);
            Pen mouth2 = new Pen(mouth1, 2);
            g.DrawEllipse(mouth2, 170, 150, 50, 10);
            mouth1.Dispose();
            mouth2.Dispose();



            Brush mybrush = new SolidBrush(Color.RosyBrown);

            g.DrawString("Gudetama",
                new Font("Verdana", 30, FontStyle.Bold),
                mybrush,
                250,
                0);
            g.Dispose();
        }
      }
    }
