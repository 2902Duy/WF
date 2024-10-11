using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FacultyBUS
    {
        public List<Faculty> GetAll()
        {
            var context = new database();
            return context.Faculties.ToList();
        }
    }
}
