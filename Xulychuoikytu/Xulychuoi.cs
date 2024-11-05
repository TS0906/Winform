using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xulychuoikytu
{
    public class Xulychuoi
    {
        public string s;
        public void Noichuoi(string s1, string s2) {
            this.s  = string.Concat(s1, s2);
        }
        public void Chenchuoi(int x, string s1, string s2)
        {
            this.s = s1.Insert(x, s2);
        }
    }
}
