using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        int stt = 1;
        public Form2()
        {
            
            InitializeComponent();
        }
        public Form2(SinhVien sinhVien)
        {
            InitializeComponent();
            txtmssv.Text= sinhVien.Mssv;
            txttensv.Text = sinhVien.Ten;
            if(sinhVien.Gt=="Nữ")
                rbtnu.Checked = true;
            else 
                rbtnam.Checked = true;
            cmbkhoa.Text = sinhVien.Khoa;
            txtdiem.Text = sinhVien.Diem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(rbtnam.Checked== false && rbtnu.Checked==false)
            rbtnu.Checked = true;
            if(cmbkhoa.Text=="")
            cmbkhoa.SelectedIndex = 0;
        }

        public SinhVien addsv()
        {
            string gt = "";
            if(rbtnu.Checked)
                gt =rbtnu.Text;
            else
                gt = rbtnam.Text;
            return new SinhVien(Convert.ToString(stt),txtmssv.Text,txttensv.Text,gt,cmbkhoa.Text,txtdiem.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Yes;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.DialogResult =DialogResult.No;
            this.Close();

        }
    }
}
