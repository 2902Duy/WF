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
    public partial class Form1 : Form
    {
        private int stt=1;
        private BindingList<SinhVien> danhSachSinhVien = new BindingList<SinhVien>();
        private BindingSource bindingSource = new BindingSource();
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            bindingSource.DataSource = danhSachSinhVien;
            dataGridView1.DataSource = bindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    
                    SinhVien sinhVien = new SinhVien();
                    sinhVien = form2.addsv();
                    danhSachSinhVien.Add(sinhVien);
                    //dataGridView1.Rows.Add(Convert.ToInt32(stt),sinhVien.Mssv,sinhVien.Ten,sinhVien.Gt,sinhVien.Khoa,sinhVien.Diem);
                    bindingSource.DataSource = danhSachSinhVien;
                    
                    stt++;
                }
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SinhVien sinhVien = new SinhVien();
                sinhVien.Mssv = row.Cells[1].Value.ToString();
                sinhVien.Ten = row.Cells[2].Value.ToString();
                sinhVien.Gt = row.Cells[3].Value.ToString();
                sinhVien.Khoa = row.Cells[4].Value.ToString();
                sinhVien.Diem = row.Cells[5].Value.ToString();
                using (Form2 form2 = new Form2(sinhVien)) 
                {
                    if (form2.ShowDialog() == DialogResult.Yes)
                    {
                        sinhVien = form2.addsv();
                        danhSachSinhVien[e.RowIndex].Stt = sinhVien.Stt;
                        danhSachSinhVien[e.RowIndex].Mssv = sinhVien.Mssv;
                        danhSachSinhVien[e.RowIndex].Ten = sinhVien.Ten;
                        danhSachSinhVien[e.RowIndex].Gt = sinhVien.Gt;
                        danhSachSinhVien[e.RowIndex].Khoa = sinhVien.Khoa;
                        danhSachSinhVien[e.RowIndex].Diem = sinhVien.Diem;
                        bindingSource.ResetBindings(false);
                    }
                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox3.Text.ToLower();
            var filteredList = danhSachSinhVien.Where(sv => sv.Ten.ToLower().Contains(searchValue)).ToList();
            bindingSource.DataSource = new BindingList<SinhVien>(filteredList);


        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            int gioi = danhSachSinhVien.Count(sv => Convert.ToInt32(sv.Diem) >= 8);
            int kha = danhSachSinhVien.Count(sv => Convert.ToInt32(sv.Diem) >= 6.5 && Convert.ToInt32(sv.Diem) < 8);
            int trungBinh = danhSachSinhVien.Count(sv => Convert.ToInt32(sv.Diem) >= 5 && Convert.ToInt32(sv.Diem) < 6.5);
            int yeu = danhSachSinhVien.Count(sv => Convert.ToInt32(sv.Diem) < 5);

            MessageBox.Show($"Giỏi: {gioi}\nKhá: {kha}\nTrung Bình: {trungBinh}\nYếu: {yeu}");
        }
    }
}
