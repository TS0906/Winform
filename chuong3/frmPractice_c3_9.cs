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
    public partial class frmPractice_c3_9 : Form
    {
        public frmPractice_c3_9()
        {
            InitializeComponent();
            txtKetQua.TabStop = false;
            txtKetQua.ReadOnly = true;
            txtKetQua.Enabled = false;
        }
        private void btnAct_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double ketqua = 0;

            if (rdAdd.Checked)
                ketqua = a + b;
            else if (rdMinus.Checked)
                ketqua = a - b;
            else if (rdPower.Checked)
                ketqua = a * b;
            else if (rdDivide.Checked)
                ketqua = a / b;

            txtKetQua.Text = ketqua.ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            rdAdd.Checked = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát Form", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
                Application.Exit();
        }
    }
}
