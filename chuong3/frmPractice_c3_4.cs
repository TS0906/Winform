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
    public partial class frmPractice_c3_4 : Form
    {
        public frmPractice_c3_4()
        {
            InitializeComponent();
            txtKiemtra.ReadOnly = true;
            txtKiemtra.TabStop = false;
            txtTim.ReadOnly = true;
            txtTim.TabStop = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void txtNhapN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtNhapN.Text, out int n))
                {
                    bool isPrime = IsPrime(n);
                    txtKiemtra.Text = isPrime ? "Là số nguyên tố" : "Không phải là số nguyên tố";
                    txtTim.Text = FindPrimesLessThanN(n);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
                }
                // Ngăn không cho âm thanh mặc định khi nhấn Enter
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private string FindPrimesLessThanN(int n)
        {
            var primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i)) primes.Add(i);
            }
            return string.Join(", ", primes);
        }
    }
}
