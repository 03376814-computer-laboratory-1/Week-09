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
            

            g.Dispose();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush pnlGdt = new LinearGradientBrush(panel1.ClientRectangle,
                Color.Yellow, Color.Navy, 0f, true);
            e.Graphics.FillRectangle(pnlGdt, panel1.ClientRectangle);
            pnlGdt.Dispose();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush pnlGdt = new LinearGradientBrush(panel2.ClientRectangle,
                Color.Yellow, Color.Navy, 90f, true);
            e.Graphics.FillRectangle(pnlGdt, panel2.ClientRectangle);
            pnlGdt.Dispose();

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(panel3.ClientRectangle);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterPoint = new PointF(panel3.ClientRectangle.Width / 2, panel3.ClientRectangle.Height / 2);
            br.CenterColor = Color.Navy;
            br.SurroundColors = new Color[] { Color.Yellow };
            e.Graphics.FillPath(br, path);
        }
    }
    }
