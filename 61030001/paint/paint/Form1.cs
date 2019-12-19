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


namespace paint
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
            Pen mypen = new Pen (Color.Black, 80);
            g.DrawRectangle(mypen, 100, 100, 300, 200);
            mypen.Width = 10;

            Pen body = new Pen(Color.Yellow, 80);
            g.DrawRectangle(body, 100, 300, 300, 200);
            body.Width = 10;

            Rectangle nose = new Rectangle(220,200,70,50);
           
            g.FillEllipse(Brushes.Brown, nose);
            nose.Width = 80;
            

            Pen eyes1 = new Pen (Color.Red,50);
            g.DrawEllipse(eyes1,80,80,90,80 );

            Pen eyes = new Pen(Color.Red, 50);
            g.DrawEllipse(eyes, 330, 80, 90, 80);

            Font f = new Font("Verdana", 20, FontStyle.Italic);
            Brush Text = new SolidBrush(Color.Green);
            g.DrawString("Mechazawa", f,Text,180,400);
            
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
