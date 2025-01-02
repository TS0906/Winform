
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Windows.Forms;

namespace chuong4_3
{
    public partial class SearchForm : Form
    {
        private string searchText;

        public SearchForm(string searchText)
        {
            InitializeComponent();
            this.searchText = searchText;
            txtSearchText.Text = searchText;
            txtResult.TabStop = false;
            txtResult.ReadOnly = true;
            txtResult.Enabled = true;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập ký tự cần tìm!");
                txtSearch.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSearchText.Text))
            {
                MessageBox.Show("Không có chuỗi để tìm kiếm!");
                return;
            }

            int vitri = txtSearchText.Text.IndexOf(txtSearch.Text);
            if (vitri >= 0)
            {
                txtResult.Text = $"Ký tự '{txtSearch.Text}' xuất hiện tại vị trí {vitri + 1}";
            }
            else
            {
                txtResult.Text = $"Không tìm thấy ký tự '{txtSearch.Text}' trong chuỗi";
            }
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtResult.Text = "Vui lòng nhập ký tự cần tìm!";
                txtSearch.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSearchText.Text))
            {
                txtResult.Text = "Không có chuỗi để tìm kiếm!";
                return;
            }

            int count = 0;
            string searchString = txtSearchText.Text;
            string searchChar = txtSearch.Text;
            int position = 0;

            while ((position = searchString.IndexOf(searchChar, position)) != -1)
            {
                count++;
                position += searchChar.Length;
            }

            if (count > 0)
            {
                MessageBox.Show($"Tìm thấy {count} ký tự trong chuỗi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy ký tự '{txtSearch.Text}' trong chuỗi");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}