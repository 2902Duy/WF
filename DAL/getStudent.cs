using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class getStudent
    {
        public List<Student> students()
        {
            List<Student> list = new List<Student>();


            using (var db = new database())
            {
                return db.Students.ToList();

            } 
            
        }

    }
}
