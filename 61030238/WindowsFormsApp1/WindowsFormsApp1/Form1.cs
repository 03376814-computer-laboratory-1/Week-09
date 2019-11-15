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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics gr_graphics = default(Graphics);
        //need a pen for drawing and make it black
        Pen pen_draw = new Pen(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen bluepen= new Pen(Color.Brown, 2);
            
            g.DrawRectangle(bluepen, 95, 200, 20, 40);
            

            bluepen.Dispose();

           
            Pen bluepenn = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepenn, 200, 200, 20, 40);




            bluepen.Dispose();

            Pen bluepennn = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepennn, 290, 200, 20, 40);




            bluepen.Dispose();
            Pen bluepennnn = new Pen(Color.Blue, 2);
            g.DrawRectangle(bluepennnn, 200, 100, 103, 20);




            bluepen.Dispose();




            gr_graphics = e.Graphics;
            Pen somepen = new Pen(Color.Brown, 2);
            //Draw a triangle on the form.
            //first have to define an array of points.

            Point[] pnt = new Point[3];

            pnt[0].X = 110;
            pnt[0].Y = 100;

            pnt[1].X = 150;
            pnt[1].Y = 200;

            pnt[2].X = 50;
            pnt[2].Y = 200;

            g.FillClosedCurve(Brushes.Lime, pnt);
            g.DrawClosedCurve(Pens.Red, pnt);
            gr_graphics.DrawPolygon(pen_draw, pnt);


            Pen bluepent = new Pen(Color.Brown, 2);
            g.DrawRectangle(bluepent, 450, 200, 20, 40);


            bluepen.Dispose();



            gr_graphics = e.Graphics;
            //Draw a triangle on the form.
            //first have to define an array of points.
            Point[] pntt = new Point[3];

            pntt[0].X = 470;
            pnt[0].Y = 100;

            pntt[1].X = 500;
            pntt[1].Y = 200;

            pntt[2].X = 400;
            pntt[2].Y = 200;

            g.FillClosedCurve(Brushes.Lime, pntt);
            g.DrawClosedCurve(Pens.Red, pntt);
            gr_graphics.DrawPolygon(pen_draw, pntt);

            
            Rectangle rect2 = new Rectangle(210, 60, 80, 80); g.FillEllipse(Brushes.Firebrick, rect2);
            // Fill ellipse
            Rectangle rect3 = new Rectangle(200, 140, 100, 100); g.FillEllipse(Brushes.Firebrick, rect3);
            g.Dispose();


            Color col = Color.FromName("LightGreen");
            this.BackColor = col;





        }
    }
    }

