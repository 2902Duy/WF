using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MajorBUS
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            var context = new database();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
