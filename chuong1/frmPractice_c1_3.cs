using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1
{
    public partial class frmPractice_c1_3 : Form
    {
        public frmPractice_c1_3()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Pen pn = new Pen(Color.Orange, 0);
            Brush faceBrush = new SolidBrush(Color.Orange);  
            Rectangle face = new Rectangle(50, 50, 200, 180);
            g.FillEllipse(faceBrush, face);
            g.DrawEllipse(pn, face);

            
            Brush eyeBrush = new SolidBrush(Color.SaddleBrown);
            Rectangle leftEye = new Rectangle(90, 100, 20, 20); 
            g.FillEllipse(eyeBrush, leftEye);  

            
            Rectangle rightEye = new Rectangle(190, 100, 20, 20);
            g.FillEllipse(eyeBrush, rightEye);  

           
            Pen mouthPen = new Pen(Color.Black, 0);
            Point[] mouthPoints = new Point[]
            {
                new Point(100, 150),  
                new Point(150, 165), 
                new Point(200, 150)   
            };
            g.DrawCurve(mouthPen, mouthPoints);  
        }
    }
}
