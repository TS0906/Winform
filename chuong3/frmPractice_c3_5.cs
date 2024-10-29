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
    public partial class frmPractice_c3_5 : Form
    {
        public frmPractice_c3_5()
        {
            InitializeComponent();
            txtOutPut.TabStop = false;
            txtOutPut.ReadOnly = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            txtNam.Text = "";
            txtThang.Text = "";
        }
        private void btnAct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNam.Text);
            int b = int.Parse(txtThang.Text);
            if(a % 4 == 0)
            {
                if (b == 2) txtOutPut.Text = $"Số ngày của tháng {b} trong năm {a} là " + 29;
                else if(b == 4 || b == 6 || b == 9 || b == 11)
                {
                    txtOutPut.Text = $"Số ngày của tháng {b} trong năm {a} là " + 30;
                }
                else
                {
                   txtOutPut.Text = $"Số ngày của tháng {b} trong năm {a} là " + 31;
                }
            }
        }
    }
}
