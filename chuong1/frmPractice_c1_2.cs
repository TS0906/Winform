using System;
using System.Drawing;
using System.Windows.Forms;

namespace day1
{
    public partial class frmPractice_c1_2 : Form
    {
        public frmPractice_c1_2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            Font f = new Font("Times New Roman", 15);
            Brush _brush = new SolidBrush(Color.Chocolate);
            PointF _pf = new PointF(130, 30);
            g.DrawString("Hello World!", f, _brush, _pf);

            Pen pn = new Pen(Color.Chocolate);
            Point[] points = new Point[]
            {
                new Point(120, 200),
                new Point(230, 200),
                new Point(255, 100),
                new Point(280, 200),
                new Point(380, 200),
                new Point(305, 250),
                new Point(330, 350),
                new Point(255, 275),
                new Point(170, 350),
                new Point(205, 250)
            };

            g.DrawPolygon(pn, points);
        }
    }
}
