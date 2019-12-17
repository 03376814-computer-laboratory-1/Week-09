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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush mybrush = new SolidBrush(Color.Black) ;
            Pen mypen = new Pen(mybrush,5);
            g.DrawEllipse(mypen,10,10,200,200);
            Rectangle eyeR = new Rectangle(69, 70, 13, 10);
            Rectangle eyeL = new Rectangle(106, 70, 13, 10);
            Rectangle Mouse = new Rectangle(85, 110, 20, 5);
            g.FillEllipse(Brushes.Black, eyeR);
            g.FillEllipse(Brushes.Black, eyeL);
            g.FillEllipse(Brushes.Black, Mouse);
            mypen.Dispose();
            mybrush.Dispose();
        }
    }
}
