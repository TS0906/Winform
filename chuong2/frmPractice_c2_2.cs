using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong2
{
    public partial class frmPractice_c2_2 : Form
    {
        public frmPractice_c2_2()
        {
            InitializeComponent();
        }

        private void btnMoveMouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là sự kiện di chuyển chuột");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblSuKien.ForeColor = Color.OrangeRed;
        }

        private void btnTextChange_Click(object sender, EventArgs e)
        {
            this.Text = "Bài tập 2 - Chương 2";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát Form", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();  
            }
        }
    }
}
