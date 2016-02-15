using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;
            Random r = new Random();

            Pen pen = new Pen(Color.BurlyWood, 2);
            float rand = r.Next(0, width);
            PointF p1 = new PointF(0, 0);
            PointF p2 = new PointF(rand, height);
            canvas.DrawLine(pen, p1, p2);
            double angle = Math.Atan(height / rand);

            if ((height / (width - rand)) >= Math.Tan(angle))
            {
                PointF p1_1 = p2;
                PointF p2_1 = new PointF(width, height - (float)(Math.Tan(angle) * (width - rand)));
                canvas.DrawLine(pen, p1_1, p2_1);
            }
            else
            {

            }
        }
    }
}
