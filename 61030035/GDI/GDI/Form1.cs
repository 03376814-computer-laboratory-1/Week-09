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

namespace GDI
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
            //earright
            Rectangle ear = new Rectangle(290, 92, 60, 60);
            g.FillEllipse(Brushes.HotPink, ear);
            g.DrawEllipse(Pens.Black, ear);
            //earlife
            Rectangle ear1 = new Rectangle(200, 92, 60, 60);
            g.FillEllipse(Brushes.HotPink, ear1);
            g.DrawEllipse(Pens.Black, ear1);
            //earright
            Rectangle ear2 = new Rectangle(300, 100, 40, 40);
            g.FillEllipse(Brushes.LightPink, ear2);
            g.DrawEllipse(Pens.Black, ear2);
            //earlife
            Rectangle ear3 = new Rectangle(210, 100, 40, 40);
            g.FillEllipse(Brushes.LightPink, ear3);
            g.DrawEllipse(Pens.Black, ear3);
            //head
            Rectangle pig = new Rectangle(200, 100, 150, 150);
             g.FillEllipse(Brushes.Pink, pig);
            g.DrawEllipse(Pens.Black, pig);
            //eyelife
            Rectangle pig1 = new Rectangle(230,150, 20, 20);
            g.FillEllipse(Brushes.Black, pig1);
            g.DrawEllipse(Pens.Black, pig1);
            //eyeright
            Rectangle pig2 = new Rectangle(295, 150, 20, 20);
            g.FillEllipse(Brushes.Black, pig2);
            g.DrawEllipse(Pens.Black, pig2);
            //nose
            Rectangle pig3 = new Rectangle(245, 180, 60, 40);
            g.FillEllipse(Brushes.HotPink, pig3);
            g.DrawEllipse(Pens.Black, pig3);
            //nose
            Rectangle pig4 = new Rectangle(255, 190, 15, 20);
            g.FillEllipse(Brushes.LightPink, pig4);
            g.DrawEllipse(Pens.Black, pig4);
            //nose1
            Rectangle nose = new Rectangle(280, 190, 15, 20);
            g.FillEllipse(Brushes.LightPink, nose);
            g.DrawEllipse(Pens.Black, nose);
            
           
            g.Dispose();

            


        }

    }
}
