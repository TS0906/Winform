using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong3
{
    public partial class frmPractice_c3_3 : Form
    {
        public frmPractice_c3_3()
        {
            InitializeComponent();
            txtUCLN.ReadOnly = true;
            txtBCNN.ReadOnly = true;
            txtUCLN.TabStop = false;
            txtBCNN.TabStop = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtUCLN.Text = "";
            txtBCNN.Text = "";
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapB.Text);
            int c = int.Parse(txtNhapA.Text);
            int d = int.Parse(txtNhapB.Text);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            txtUCLN.Text = a.ToString();
            txtBCNN.Text = (c*d/a).ToString();
        }
    }
}
