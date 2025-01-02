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
    public partial class Bai2_Chuong4 : Form
    {
        public Bai2_Chuong4()
        {
            InitializeComponent();
        }
        private void btnNhapChuoi_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            txtNoiDung.Clear();
            for (int i = 0; i < 10; i++)
            {
                txtNoiDung.Text += chars[random.Next(chars.Length)];
            }

            ApplyTextCase();
        }

        private void rdoChuHoa_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTextCase();
        }

        private void rdoChuThuong_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTextCase();
        }

        // Áp dụng định dạng chữ hoa/thường
        private void ApplyTextCase()
        {
            if (rdoChuHoa.Checked)
            {
                txtNoiDung.Text = txtNoiDung.Text.ToUpper();
            }
            else if (rdoChuThuong.Checked)
            {
                txtNoiDung.Text = txtNoiDung.Text.ToLower();
            }
        }

        // Sự kiện khi nhấn nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
        }

        // Sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
