using System;
using System.Windows.Forms;
using Xulymang;

namespace chuong4_2
{
    public partial class frmC4_Vd4_6 : Form
    {
        public frmC4_Vd4_6()
        {
            InitializeComponent();
        }

        //private string[] DSLop()
        //{
        //    return new string[]
        //    {
        //        "K46A Công nghệ thông tin 1",
        //        "K47B Công nghệ thông tin 2",
        //        "K48L Công nghệ thông tin 3"
        //    };
        //}

        //private string[] DSLHP(string classname)
        //{
        //    if (classname == "46A")
        //    {
        //        return new string[] { "Mạng máy tính", "Kiến trúc máy tính", "Lập trình hướng đối tượng" };
        //    }
        //    else if (classname == "47B")
        //    {
        //        return new string[] { "Mạng máy tính", "Kiến trúc máy tính", "Lập trình Windows" };
        //    }
        //    else if (classname == "48L")
        //    {
        //        return new string[] { "Tin học đại cương", "Tiếng Anh 3", "Phương pháp lập trình" };
        //    }
        //    return new string[] { };
        //}

        private void frmC4_Vd4_6_Load(object sender, EventArgs e)
        {
            cboLopdanhnghia.Items.Clear();
            clsMang _objMang = new clsMang();
            string[] ds = _objMang.DSLop();
            //string[] ds = DSLop();
            foreach (string s in ds)
            {
                cboLopdanhnghia.Items.Add(s);
            }
            cboLopdanhnghia.SelectedIndex = 0;
            cboLopdanhnghia.Refresh();
        }

        private void cboLopdanhnghia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLopHP.Items.Clear();
            string classname = "";
            if (cboLopdanhnghia.SelectedIndex == 0) classname = "46A";
            else if (cboLopdanhnghia.SelectedIndex == 1) classname = "47B";
            else if (cboLopdanhnghia.SelectedIndex == 2) classname = "48L";
            clsMang _objMang = new clsMang();
            string[] ds = _objMang.DSLHP(classname);
            //string[] ds = DSLHP(classname);
            foreach (string subject in ds)
            {
                lstLopHP.Items.Add(subject);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát Form", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes) Application.Exit();
        }
    }
}
