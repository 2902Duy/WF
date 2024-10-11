using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
namespace BUS
{
    public class studentBUS
    {
        private getStudent st = new getStudent();

        public List<Student> GetAll()
        {
            database context = new database();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            database context = new database();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            database context = new database();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public Student FindById(int studentId)
        {
            database context = new database();
            return context.Students.FirstOrDefault(p => p.StudentID==studentId);
        }

        public void InsertUpdate(Student s)
        {
            database context = new database();
            
            context.Students.Add(s);
            context.SaveChanges();
        }
        public void DeleteStudent(int studentID)
        {
            database context = new database();
            Student student = context.Students.Where(predicate => predicate.StudentID == studentID).SingleOrDefault();
            context.Students.Remove(student);
            context.SaveChanges();

        }
    }
}
