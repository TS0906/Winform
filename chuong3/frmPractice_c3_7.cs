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
    public partial class frmPractice_c3_7 : Form
    {
        public frmPractice_c3_7()
        {
            InitializeComponent();
            rtbKetQua.ReadOnly = true; 
            rtbKetQua.TabStop = false;
            rtbKetQua.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbKetQua.Clear();
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (lstWebsite.SelectedItem != null)
            {
                rtbKetQua.Text = $"Website bạn đã chọn là: {lstWebsite.SelectedItem.ToString()}";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một website từ danh sách!", "Thông báo");
            }
        }
    }
}
