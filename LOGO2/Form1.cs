using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this si a test comment
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
 // Code for text creation
            Graphics g2 = this.CreateGraphics();
            Font drawFont = new Font("Arial", 30, FontStyle.Italic);
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);
            // Code for line creation
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 100);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            //Line drawing
            g.Clear(Color.Blue);
            g.DrawLine(drawPen, 405, 150, 580, 409);
            g.DrawLine(drawPen, 240, 411, 395, 150);
            g.DrawLine(drawPen, 280, 386, 545, 386);
            g.DrawLine(drawPen, 354, 171, 445, 170);
            drawPen = new Pen (Color.White, 3);
            g.DrawLine(drawPen, 405, 150, 570, 400);
            g.DrawLine(drawPen, 240, 400, 395, 150);
            g.DrawLine(drawPen, 279, 400, 395, 150);
            g.DrawLine(drawPen, 325, 386, 640, 386);
            g.DrawLine(drawPen, 370, 165, 432, 165);
            // text drawing

            g.DrawString("PALACE", drawFont, drawBrush2, 50, 40);
            g.TranslateTransform(230, 340);
            g.RotateTransform(-60);

            g.DrawString("PALACE", drawFont, drawBrush, new Rectangle());

            g.ResetTransform();


        }
    }
}
