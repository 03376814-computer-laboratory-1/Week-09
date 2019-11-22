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
            Rectangle dog = new Rectangle(200, 100, 150, 150);
             g.FillEllipse(Brushes.Pink, dog);
            g.DrawEllipse(Pens.Black, dog);
            //eyelife
            Rectangle dog1 = new Rectangle(230,150, 20, 20);
            g.FillEllipse(Brushes.Black, dog1);
            g.DrawEllipse(Pens.Black, dog1);
            //eyeright
            Rectangle dog2 = new Rectangle(295, 150, 20, 20);
            g.FillEllipse(Brushes.Black, dog2);
            g.DrawEllipse(Pens.Black, dog2);
            //nose
            Rectangle dog3 = new Rectangle(245, 180, 60, 40);
            g.FillEllipse(Brushes.HotPink, dog3);
            g.DrawEllipse(Pens.Black, dog3);
            //nose
            Rectangle dog4 = new Rectangle(255, 190, 15, 20);
            g.FillEllipse(Brushes.LightPink, dog4);
            g.DrawEllipse(Pens.Black, dog4);
            //nose1
            Rectangle nose = new Rectangle(280, 190, 15, 20);
            g.FillEllipse(Brushes.LightPink, nose);
            g.DrawEllipse(Pens.Black, nose);
            
           
            g.Dispose();

            


        }

    }
}
