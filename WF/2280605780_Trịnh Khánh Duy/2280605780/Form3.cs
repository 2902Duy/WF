using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280605780
{
    public partial class Form3 : Form
    {
        database db = new database();
        public Form3()
        {
            InitializeComponent();
            FillFalcultyCombobox(db);

        }

        public void loaddata(database db)
        {
            var sql = from s in db.Students
                      select new { 
                          s.StudentID, 
                          s.FullName, 
                          s.AverageScore, 
                          s.Gender, 
                          Faculty=s.Faculty.FacultyName };
            dataGridView1.DataSource = sql.ToList();
        }
        private void FillFalcultyCombobox(database db)
        {

            var sql = from f in db.Faculties
                      select f;
            List<Faculty> listFacultys = sql.ToList();
            listFacultys.Insert(0, new Faculty());
            this.cmbKhoa.DataSource = listFacultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            var sql = from s in db.Students
                      select new
                      {
                          s.StudentID,
                          s.FullName,
                          s.AverageScore,
                          s.Gender,
                          Faculty = s.Faculty.FacultyName
                      };
            int? studentID = string.IsNullOrEmpty(txtmssv.Text) ? (int?)null : int.Parse(txtmssv.Text);
            string fullName = txtten.Text;  
            string gender = rbtnam.Checked ? "Male" : "";
            gender = rbtnu.Checked ? "Female" : "";
            //int facultyID = (cmbKhoa.SelectedItem as Faculty).FacultyID;
            string faculty = cmbKhoa.Text;
            if (studentID.HasValue)
            {
                sql = sql.Where((s)=>s.StudentID==studentID);
            }
            if (fullName != "")
            {
                sql =sql.Where((s)=>s.FullName==fullName);
            }
            if(gender != "")
            {
                sql =sql.Where((s)=>s.Gender==gender);
            }
            if (faculty != "")
            {
                sql =sql.Where((s)=>s.Faculty==faculty);
            }
            
            dataGridView1.DataSource = sql.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sql = from s in db.Students
                      select new
                      {
                          s.StudentID,
                          s.FullName,
                          s.AverageScore,
                          s.Gender,
                          Faculty = s.Faculty.FacultyName
                      };
            int? studentID = string.IsNullOrEmpty(txtmssv.Text) ? (int?)null : int.Parse(txtmssv.Text);
            string fullName = txtten.Text;
            string gender = rbtnam.Checked ? "Male" : "Female";
            int facultyID = (cmbKhoa.SelectedItem as Faculty).FacultyID;
            string faculty = cmbKhoa.Text;
            if (studentID.HasValue)
            {
                Student st =db.Students.Find(studentID.Value);
                db.Students.Remove(st);

            }
            if (fullName != "")
            {
                List<Student> st = db.Students.Where(s => s.FullName == fullName).ToList();
                foreach (Student student in st)
                {
                    db.Students.Remove(student);
                }

                
            }
            if (gender != "")
            {
                List<Student> st = db.Students.Where(s=>s.Gender==gender).ToList();
                foreach (Student student in st)
                {
                    db.Students.Remove(student);
                }
            }
            if (faculty != "")
            {
                List<Student> st = db.Students.Where(s => s.Faculty.FacultyName ==faculty).ToList();
                foreach (Student student in st)
                {
                    db.Students.Remove(student);
                }
                Faculty fa = db.Faculties.Find(facultyID);
                db.Faculties.Remove(fa);
            }

            dataGridView1.DataSource = sql.ToList();

        }
    }
}
