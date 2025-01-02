using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Xulymang
{
    public class clsMang
    {
        public string[] ds;
        public clsMang()
        {
            ds = new string[3];
        }
        public string[] DSLop()
        {
            this.ds = new string[3];
            this.ds[0] = "K46A Công nghệ thông tin 1";
            this.ds[1] = "K47B Công nghệ thông tin 2";
            this.ds[2] = "K48L Công nghệ thông tin 3";
            return this.ds;
        }
        public string[] DSLHP(string classname)
        {
            this.ds = new string[3];
            if (classname == "46A")
            {
                this.ds[0] = "Mạng máy tính";
                this.ds[1] = "Kiến trúc máy tính";
                this.ds[2] = "Lập trình hướng đối tượng";
            }
            else if (classname == "47B")
            {
                this.ds[0] = "Mạng máy tính";
                this.ds[1] = "Kiến trúc máy tính";
                this.ds[2] = "Lập trình Windows";
            }
            else if (classname == "48L")
            {
                this.ds[0] = "Tin học đại cương";
                this.ds[1] = "Tiếng Anh 3";
                this.ds[2] = "Phương pháp lập trình";
            }
            return this.ds;
        }
    }
}