using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong2
{
    public partial class frmPractice_c2_3 : Form
    {
        public frmPractice_c2_3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Form Closing chuột trên Form");
            MessageBox.Show("Đây là sự kiện Form Closed chuột trên Form");
            Application.Exit();
        }
        private void frmPractice_c2_1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với Bài tập thực hành tự làm số 2 – Chương 2", "Thông báo");
            this.Text = "Bài tập thực hành tự làm số 2 – Chương 2";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Click chuột trên Form");
        }
    }
}
