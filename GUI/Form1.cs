using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
namespace GUI
{
    public partial class Form1 : Form
    {
        private studentBUS studentBUS = new studentBUS();
        private FacultyBUS facultyBUS = new FacultyBUS();
        private MajorBUS majorBUS = new MajorBUS(); 
        public Form1()
        {
            InitializeComponent();


        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.checkBox1.Checked)
                listStudents = studentBUS.GetAllHasNoMajor();
            else
                listStudents = studentBUS.GetAll();
            BindGrid(listStudents);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
                var students = studentBUS.GetAll();
                var faculty = facultyBUS.GetAll();
                BindGrid(students);
                FillFalcultyCombobox(faculty);
                
            //}
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
          //  }

        }

        private void BindGrid(List<Student> students)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
                if (item.MajorID != null)
                    dataGridView1.Rows[index].Cells[4].Value = item.Major.MajorName;
                //ShowAvatar(item.Avartar);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows;
                textBox1.Text = selectedRow[0].Cells["StudentID"].Value.ToString();
                textBox2.Text = selectedRow[0].Cells["FullName"].Value.ToString();
                textBox3.Text = selectedRow[0].Cells["AverageScore"].Value.ToString();
                comboBox1.Text = selectedRow[0].Cells["FacultyName"].Value.ToString();
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.comboBox1.DataSource = listFacultys;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";

        }

        private void ShowAvatar(string ImageName)
        {

            if (string.IsNullOrEmpty(ImageName))
            {
                pictureBox1.Image = null;
            }
            else
            {
                string parentDirectory =
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Refresh();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(textBox1.Text);
            string fullName = textBox2.Text;
            double averageScore = Convert.ToDouble(textBox3.Text);
            int facultyID = (comboBox1.SelectedItem as Faculty).FacultyID; 
 
            // Tạo đối tượng Student
            Student student = new Student()
            {
                StudentID = studentID,
                FullName = fullName,
                AverageScore = averageScore,
                FacultyID = facultyID
            };
            
            // Gọi phương thức InsertUpdate
            studentBUS.InsertUpdate(student);

            // Thông báo thành công
            MessageBox.Show("Student information saved successfully!");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            studentBUS.DeleteStudent(id);
            MessageBox.Show("Student information remove successfully!");
        }
    }
}
