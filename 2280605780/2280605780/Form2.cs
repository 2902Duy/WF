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
    public partial class Form2 : Form
    {
        database db = new database();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddata(db);
            
        }

        public void loaddata(database db)
        {
            var sql = from f in db.Faculties
                      select f;
            dataGridView1.DataSource = sql.ToList();
            txttong.Text = sql.Sum(s => s.TotalProfessor).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["FacultyID"].Value.ToString();
            txttenkhoa.Text = dataGridView1.Rows[e.RowIndex].Cells["FacultyName"].Value.ToString();
            txttonggs.Text = dataGridView1.Rows[e.RowIndex].Cells["TotalProfessor"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkKhoa()==false)
            {
                MessageBox.Show("Ma Khoa da ton tai");
                return;
            }    
               
            int facultyID = int.Parse(txtmakhoa.Text);
            string facultyName = txttenkhoa.Text;
            int totalProfessor = int.Parse(txttonggs.Text);
            Faculty faculty = new Faculty
            {
                FacultyID = facultyID,
                FacultyName = facultyName,
                TotalProfessor = totalProfessor
            };
            db.Faculties.Add( faculty );
            db.SaveChanges();
            loaddata(db);
        }

        private bool checkKhoa()
        {
            try
            {
                if (db.Faculties.Any(s => s.FacultyID == int.Parse(txtmakhoa.Text)))
                    return false;
            }
            catch { return false; }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmakhoa.Text);
            database context = new database();
            Faculty faculty = context.Faculties.Where(predicate => predicate.FacultyID == id).SingleOrDefault();
            context.Faculties.Remove(faculty);
            context.SaveChanges();
            loaddata(db);
            
        }

        private void cmbsapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbsapxep.Text=="Tăng dần")
            {
                var dbtang = from s in db.Faculties
                             orderby s.TotalProfessor ascending
                             select s;
                dataGridView1.DataSource = dbtang.ToList();
            }   
            if(cmbsapxep.Text=="Giảm dần")
            {
                var dbtang = from s in db.Faculties
                             orderby s.TotalProfessor descending
                             select s;
                dataGridView1.DataSource = dbtang.ToList();
            }    
        }
    }
}
