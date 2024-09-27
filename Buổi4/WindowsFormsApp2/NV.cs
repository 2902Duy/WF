using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class NV
    {
        

        public NV(string mSNV, string tENNV, string lUONGCB)
        {
            MSNV = mSNV;
            TENNV = tENNV;
            LUONGCB = lUONGCB;
        }
        public NV() { }

        public string MSNV { get => MSNV; set => MSNV = value; }
        public string TENNV { get => TENNV; set => TENNV = value; }
        public string LUONGCB { get => LUONGCB; set => LUONGCB = value; }
    }
}
