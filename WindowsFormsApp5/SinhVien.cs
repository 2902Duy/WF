using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SinhVien
    {
        private string stt;
        private string mssv;
        private string ten;
        private string gt;
        private string khoa;
        private string diem;

        public SinhVien(string stt,string mssv, string ten, string gt, string khoa, string diem)
        {
            this.stt = stt;
            this.mssv = mssv;
            this.ten = ten;
            this.gt = gt;
            this.khoa = khoa;
            this.diem = diem;
        }
        public SinhVien()
        {

        }

        public string Stt { get => stt; set => stt = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gt { get => gt; set => gt = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Diem { get => diem; set => diem = value; }

    }
}
