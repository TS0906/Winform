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
    public partial class Bai3_Chuong4 : Form
    {
        public Bai3_Chuong4()
        {
            InitializeComponent();
            txtMangketqua.ReadOnly = true;
            txtMangketqua.TabStop = false;
            txtMangketqua.Enabled = true;
            txtTongchan.ReadOnly = true;
            txtTongchan.TabStop = false;
            txtTongchan.Enabled = true;
            txtTongle.ReadOnly = true;
            txtTongle.TabStop = false;
            txtTongle.Enabled = true;
            txtTongmang.ReadOnly = true;
            txtTongmang.TabStop = false;
            txtTongmang.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private int[] TachMang(string input)
        {
            try
            {
                return input.Split(';').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Array.Empty<int>();
            }
        }
        private void SapXepMang(ref int[] arr, bool tangDan = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (tangDan ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private int[] ThemPhanTu(int[] arr, int x, int v)
        {
            if (v < 0 || v > arr.Length)
            {
                MessageBox.Show($"Không tìm thấy vị trí {v} trong mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return arr;
            }

            int[] newArr = new int[arr.Length + 1];
            for (int i = 0, j = 0; i < newArr.Length; i++)
            {
                if (i == v) newArr[i] = x;
                else newArr[i] = arr[j++];
            }
            return newArr;
        }
        private (int tong, int tongChan, int tongLe) TinhTong(int[] arr)
        {
            int tong = arr.Sum();
            int tongChan = arr.Where(x => x % 2 == 0).Sum();
            int tongLe = arr.Where(x => x % 2 != 0).Sum();
            return (tong, tongChan, tongLe);
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            int[] arr = TachMang(txtNhapmang.Text);
            if (rdoTangdan.Checked == false && rdoGiamdan.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (arr.Length == 0)
            {
                MessageBox.Show("Mảng rỗng. Vui lòng nhập dãy số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdoTangdan.Checked)
            {
                SapXepMang(ref arr);
            }
            else
            {
                SapXepMang(ref arr, false);
            }

            txtMangketqua.Text = string.Join(";", arr);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int[] arr = TachMang(txtNhapmang.Text);
            int x = int.Parse(txtGiatrithem.Text);
            int v = int.Parse(txtVitrithem.Text);
            arr = ThemPhanTu(arr, x, v);
            txtMangketqua.Text = string.Join(";", arr);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int[] arr = TachMang(txtNhapmang.Text);
            var (tong, tongChan, tongLe) = TinhTong(arr);
            txtTongmang.Text = tong.ToString();
            txtTongchan.Text = tongChan.ToString();
            txtTongle.Text = tongLe.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapmang.Clear();
            txtMangketqua.Clear();
            txtTongmang.Clear();
            txtTongle.Clear();
            txtTongchan.Clear();
            txtGiatrithem.Clear();
            txtVitrithem.Clear();
        }
    }
}
