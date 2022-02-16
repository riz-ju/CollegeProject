using CollegeProjectModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectServices.Interface
{
    public interface IStudentService
    {
        public List<Student> GetS();
        public List<Student> GetByIdS(int id);
        public List<Student> GetByNameS(string name);
        public List<Student> GetByAgeS(int age);
        public dynamic GetByjoiningDateS(DateTime joningDate, DateTime ejoningTime);

        public List<Student> PostS(int myid, string myname, string mydepartment, int myage, DateTime myjoiningDate);
        public List<Student> PutS(int id, string myname, string mydepartment, int myage, DateTime myjoiningDate);

        public List<Student> DeleteS(int id);
    }
}
