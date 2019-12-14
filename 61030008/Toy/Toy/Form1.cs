using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy
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
            Rectangle rect1 = new Rectangle(220, 50, 200, 150);
            e.Graphics.FillEllipse(Brushes.YellowGreen, rect1);


            Rectangle rect2 = new Rectangle(250, 100, 35, 35);
            e.Graphics.FillEllipse(Brushes.White , rect2);
            Rectangle rect5 = new Rectangle(260, 110, 15, 15);
            e.Graphics.FillEllipse(Brushes.Black, rect5);

            Rectangle rect3 = new Rectangle(300, 100, 35, 35);
            e.Graphics.FillEllipse(Brushes.White, rect3);
            Rectangle rect6 = new Rectangle(310, 110, 15, 15);
            e.Graphics.FillEllipse(Brushes.Black, rect6);

            Rectangle rect4 = new Rectangle(350, 100, 35, 35);
            e.Graphics.FillEllipse(Brushes.White, rect4);
            Rectangle rect7 = new Rectangle(360, 110, 15, 15);
            e.Graphics.FillEllipse(Brushes.Black, rect7);

            Rectangle rect9 = new Rectangle(220, 150, 200, 150);
            e.Graphics.FillEllipse(Brushes.YellowGreen, rect9);

            Rectangle rect10 = new Rectangle(250, 190, 130, 80);
            e.Graphics.FillEllipse(Brushes.White, rect10);


            Rectangle rect11 = new Rectangle(250, 290, 60, 30);
            e.Graphics.FillEllipse(Brushes.Green, rect11);

            Rectangle rect12 = new Rectangle(330, 290, 60, 30);
            e.Graphics.FillEllipse(Brushes.Green, rect12);


            Rectangle rect13 = new Rectangle(180, 190, 60, 30);
            e.Graphics.FillEllipse(Brushes.Green, rect13);

            Rectangle rect14 = new Rectangle(400, 190, 60, 30);
            e.Graphics.FillEllipse(Brushes.Green, rect14);

            Pen pen = new Pen(Color.Green);
            Point[] pt = {new Point(250,160),new Point(280,160)
                    ,new Point(290,150),new Point(300,160),new Point(310,150)
                    ,new Point(320,160),new Point(330,150),new Point(340,160)
                    ,new Point(370,160)

             
            };
            Brush myBrush = new SolidBrush(Color.Black);
           g.DrawString("Hi everybody!! I'm alien.",// String 
                new Font("Verdana", 20, FontStyle.Bold),//Font,size,style
                myBrush,
                0,       // x position to display font
                0);  // x position to display font
               
            e.Graphics.DrawCurve(pen, pt);

            g.Dispose();
        }
    }
 }
