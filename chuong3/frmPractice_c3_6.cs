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
    public partial class frmPractice_c3_6 : Form
    {
        public frmPractice_c3_6()
        {
            InitializeComponent();
            txtOutPut.ReadOnly = true;
            txtOutPut.TabStop = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtOutPut.Text = "";
        }
        private void btnAct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int max = a;
            if (max < b)
            {
                max = b;
            }
            else if (max < c) 
            {
                max = c;
            }
            txtOutPut.Text = $"Số lớn nhất là {max}";
        }
    }
}
