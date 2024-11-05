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
    public partial class frmPractice_c3_8 : Form
    {
        public frmPractice_c3_8()
        {
            InitializeComponent();
            txtOutPut.ReadOnly = true;
            txtOutPut.TabStop = false;
            txtOutPut.Enabled = false;
            for (int i = 1; i <= 31; i++)
            {
                cmbNgay.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int i = 1990; i <= 2023; i++)
            {
                cmbNam.Items.Add(i);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (txtTruong !=null && cmbNgay.SelectedItem != null && cmbThang.SelectedItem != null && cmbNam.SelectedItem != null)
            {
                txtOutPut.Text = txtTruong.Text + Environment.NewLine +
                 $"Ngày {cmbNgay.SelectedItem}, Tháng {cmbThang.SelectedItem}, Năm {cmbNam.SelectedItem}" + Environment.NewLine +
                 rtbInPut.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng cập nhật đầy đủ thông tin!", "Thông báo");
            }
        }
    }
}
