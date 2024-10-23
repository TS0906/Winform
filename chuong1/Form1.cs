using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Vẽ hình chữ nhật:
        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    Graphics g = pe.Graphics;
        //    Rectangle rect = new Rectangle(50, 30, 100, 200); 
        //    LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.ForwardDiagonal); 
        //    g.FillRectangle(lBrush, rect);
        //}
        //Vẽ đường cong:
        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    Graphics g = pe.Graphics; Pen pn = new Pen(Color.Blue);
        //    Rectangle rect = new Rectangle(50, 50, 200, 100);
        //    g.DrawArc(pn, rect, 12, 84);
        //}
        //Vẽ đường thẳng
        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    Graphics g = pe.Graphics;
        //    Pen pn = new Pen(Color.Blue); 
        //    Point pt1 = new Point(30, 30); 
        //    Point pt2 = new Point(110, 100); 
        //    g.DrawLine(pn, pt1, pt2);
        //}
        //Vẽ hình Ellipse
        //    protected override void OnPaint(PaintEventArgs pe)
        //{
        //    Graphics g = pe.Graphics;
        //    Pen pn = new Pen(Color.Blue, 100);
        //    Rectangle rect = new Rectangle(50, 50, 200, 100); 
        //    g.DrawEllipse(pn, rect);
        //}
        //Viết chữ lên Form
//protected override void OnPaint(PaintEventArgs pe)
//        {
//            Graphics g = pe.Graphics;
//            Font f = new Font("Times New Roman", 15); 
//            Brush _brush = new SolidBrush(Color.Chocolate); 
//            PointF _pf = new PointF(130, 30); 
//            g.DrawString("Hello World !", f, _brush, _pf);
//        }

    }
}
