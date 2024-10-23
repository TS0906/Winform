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
    public partial class frmPractice_c1_1 : Form
    {
        public frmPractice_c1_1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            //rectangle
            Graphics g = pe.Graphics;
            Rectangle rect = new Rectangle(80, 30, 100, 200); 
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.ForwardDiagonal); 
            g.FillRectangle(lBrush, rect);
            //circle
            Graphics a = pe.Graphics;
            Rectangle cir = new Rectangle(230, 80, 100, 100);
            LinearGradientBrush cBrush = new LinearGradientBrush(cir,Color.Orange,Color.Magenta,LinearGradientMode.Vertical);
            a.FillEllipse(cBrush, cir);
            Pen pn = new Pen(Color.White, 0);
            a.DrawEllipse(pn, cir);
        }
    }
}
