using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xulychuoikytu;

namespace chuong4
{
    public partial class frmXulychuoi : Form
    {
        public frmXulychuoi()
        {
            InitializeComponent();
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            Xulychuoi clsXLC = new Xulychuoi();
            clsXLC.Noichuoi(txtChuoi1.Text, txtChuoi2.Text);
            if (rdoChenchuoi.Checked)
            {
                clsXLC.Chenchuoi(int.Parse(txtVitri.Text), clsXLC.s, txtChuoi3.Text);
            }
            lblKetqua.Text.Clone();
            lblKetqua.Text = clsXLC.s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXulychuoi_Load(object sender, EventArgs e)
        {
            rdoNoichuoi.Checked = true;
            rdoChenchuoi.Checked = false;
        }

        private void rdoNoichuoi_CheckedChanged(object sender, EventArgs e)
        {
            txtVitri.Enabled = false;
            txtVitri.Clear();
            txtChuoi3.TabStop = false;
            txtChuoi3.ReadOnly = true;
        }

        private void rdoChenchuoi_CheckedChanged(object sender, EventArgs e)
        {
            txtVitri.Enabled = true; txtVitri.Clear();
        }
    }
}
