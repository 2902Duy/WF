using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2280605780
{

    public partial class Form1 : Form
    {
        database db = new database();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            loaddata(db);
            
            
            FillFalcultyCombobox(db);
            
        }

        public void loaddata(database db)
        {
            
            var sql = from s in db.Students
                      select new
                      {
                          s.StudentID,
                          s.FullName,
                          s.AverageScore,
                          s.Gender,
                          Faculty = s.Faculty.FacultyName,
                      };
            dataGridView1.DataSource = sql.ToList();
            txtslNam.Text = db.Students.Count(row => row.Gender.ToString() == "Male").ToString();
            txtslNu.Text = db.Students.Count(row => row.Gender.ToString() == "Female").ToString();
        }

        public void bindings(database db)
        {
            txtmssv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "StudentID"));
            txtTen.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FullName"));
            txtDiem.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "AverageScore"));
            cmbKhoa.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Faculty"));

            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmssv.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtDiem.Text = dataGridView1.Rows[e.RowIndex].Cells["AverageScore"].Value.ToString();
                if(dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString()=="Male")
                    rbtNam.Checked= true;
                else 
                    rbtNu.Checked= true;
                cmbKhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["Faculty"].Value.ToString();
            }


        }
        private void FillFalcultyCombobox(database db)
        {
            
            var sql = from f in db.Faculties
                               select f;
            List<Faculty>listFacultys = sql.ToList();
            listFacultys.Insert(0, new Faculty());
            this.cmbKhoa.DataSource = listFacultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            database db = new database();
            int studentID = int.Parse(txtmssv.Text);
            string fullName = txtTen.Text;
            float averageScore = float.Parse(txtDiem.Text);
            string gender = rbtNam.Checked ? "Male" : "Female";
            int facultyID = (cmbKhoa.SelectedItem as Faculty).FacultyID;
            Student student = new Student()
            {
                StudentID = studentID,
                FullName = fullName,
                AverageScore = averageScore,
                Gender = gender,
                FacultyID = facultyID
            };
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Student information add successfully!");
            loaddata(db);
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmssv.Text);
            database context = new database();
            Student student = context.Students.Where(predicate => predicate.StudentID == id).SingleOrDefault();
            context.Students.Remove(student);
            context.SaveChanges();
            loaddata(db);
            
            MessageBox.Show("Student information remove successfully!");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using(Form2 form = new Form2())
            {
                form.ShowDialog();
            }
        }
    }
}
