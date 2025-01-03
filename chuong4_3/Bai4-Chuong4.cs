using System;
using System.CodeDom.Compiler;
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
    public partial class Bai4_Chuong4 : Form
    {
        public Bai4_Chuong4()
        {
            InitializeComponent();
            txtMangketqua.ReadOnly = true;
            txtMangketqua.TabStop = false;
            txtMangketqua.Enabled = true;
            txtLonnhat.Enabled = true;
            txtNhonhat.Enabled = true;
            txtNhonhat.ReadOnly = true;
            txtLonnhat.ReadOnly = true;
            txtLonnhat.TabStop = false;
            txtNhonhat.TabStop = false;
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
                return input.Split('-').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Array.Empty<int>();
            }
        }
        private void MergeSort(ref int[] arr)
        {
            if (arr.Length <= 1) return;

            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();
            MergeSort(ref left);
            MergeSort(ref right);
            arr = Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }
            while (i < left.Length)
            {
                result.Add(left[i]);
                i++;
            }
            while (j < right.Length)
            {
                result.Add(right[j]);
                j++;
            }

            return result.ToArray();
        }
        private void MaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
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
            MergeSort(ref arr);

            if (rdoGiamdan.Checked)
            {
                Array.Reverse(arr);
            }

            txtMangketqua.Text = string.Join("-", arr);

        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr = TachMang(txtNhapmang.Text);
            int max, min;
            MaxMin(arr, out max, out min);
            txtLonnhat.Text = max.ToString();
            txtNhonhat.Text = min.ToString();
        }

        private void btnThaythe_Click(object sender, EventArgs e)
        {
            int[] arr = TachMang(txtNhapmang.Text);
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Mảng trống! Vui lòng nhập và sắp xếp trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdoGiatri.Checked)
            {
                if (int.TryParse(txtGiatrithaythe.Text, out int x) &&
                    int.TryParse(txtSothaythe.Text, out int y))
                {
                    bool replaced = false;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == x)
                        {
                            arr[i] = y;
                            replaced = true;
                        }
                    }

                    if (!replaced)
                    {
                        MessageBox.Show("Không tìm thấy giá trị cần thay thế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá trị hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdoViri.Checked)
            {
                if (int.TryParse(txtVitrithaythe.Text, out int index) &&
                    int.TryParse(txtSothaythe.Text, out int value))
                {
                    if (index >= 0 && index < arr.Length)
                    {
                        arr[index] = value;
                    }
                    else
                    {
                        MessageBox.Show("Vị trí không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vị trí và giá trị hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtMangketqua.Text = string.Join("-", arr);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMangketqua.Clear();
            txtNhapmang.Clear();
            txtLonnhat.Clear();
            txtNhonhat.Clear();
            txtSothaythe.Clear();
        }
    }
}
