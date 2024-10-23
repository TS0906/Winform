using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong2
{
    public partial class frmPractice_c2_1 : Form
    {
        public frmPractice_c2_1()
        {
            InitializeComponent();
        }
        private void btnDoitieude_Click(object sender, EventArgs e)
        {
            this.Text = "Bài thực hành về tương tác Form";
        }
        private void btnThemForm_Click(object sender, EventArgs e)
        {
            Form frm = new Form(); 
            frm.Text = "Tạo Form mới";
            frm.StartPosition = FormStartPosition.CenterScreen; 
            frm.Size = new Size(300, 200);
            frm.ShowDialog();
        }
        private void btnGoiFormKhac_Click(object sender, EventArgs e)
        {
            frmPractice_c2_2 frm = new frmPractice_c2_2(); 
            frm.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không ?","Thoát Form", MessageBoxButtons.YesNo); 
            if (hoi == DialogResult.Yes) Application.Exit();
        }

    }
}
