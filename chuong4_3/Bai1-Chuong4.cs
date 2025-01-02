using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtKetqua.Enabled = true;
            txtKetqua.ReadOnly = true;
            txtKetqua.TabStop = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát Form", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes) Application.Exit();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            if(rdLowerCase.Checked == true)
            {
                txtKetqua.Text = txtNoidung.Text.ToLower();
            }
            else if (rdUpperCase.Checked == true)
            {
                txtKetqua.Text = txtNoidung.Text.ToUpper();
            }
            else
            {
                txtKetqua.Text = txtNoidung.Text;
            }
            txtKetqua.Text = txtKetqua.Text.Replace(" ", "");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = "";
            txtNoidung.Text = "";
        }
    }
}
