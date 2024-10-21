using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binding
{
    public partial class Form1 : Form
    {
        data db = new data();
        public BindingSource binding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            txtname.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FULLNAME", true, DataSourceUpdateMode.Never));
            txttuoi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "AGE", true, DataSourceUpdateMode.Never));
            comboBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MAJOR", true, DataSourceUpdateMode.Never));
        }
        public void loaddata()
        {
            var sql = from st in db.Students
                      select st;
           
            binding.DataSource = sql.ToList();
            dataGridView1.DataSource = binding;
        }
        

        private void FillSPCombobox()
        {

            var sql = from st in db.Students
                      select st.Major;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var id = db.Students.Max(s=>s.StudentId);
            Student st = new Student
            {
                StudentId = id+1,
                FullName = txtname.Text,
                Age = int.Parse(txttuoi.Text),
                Major = comboBox1.Text
            };
            db.Students.Add(st);
            db.SaveChanges();
            loaddata();
            binding.ResetBindings(false);
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var st = db.Students.Where(s=>s.FullName.Equals(txtname.Text)).FirstOrDefault();
            st.Age = int.Parse(txttuoi.Text);
            st.Major = comboBox1.Text;
            db.SaveChanges();
            loaddata();
            binding.ResetBindings(false);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var st = db.Students.Where(s => s.FullName.Equals(txtname.Text)).First();
            db.Students.Remove(st);
            db.SaveChanges();
            loaddata();
            binding.ResetBindings(false);
        }
    }
}
