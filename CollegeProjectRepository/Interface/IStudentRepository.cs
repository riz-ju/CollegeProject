using CollegeProjectData;
using CollegeProjectModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectRepository.Interface
{
    public interface IStudentRepository
    {
        public List<Student> GetR();
        public List<Student> GetByIdR(int id);
        public List<Student> GetByNameR(string name);
        public List<Student> GetByAgeR(int age);
        public dynamic GetByjoiningDateR(DateTime joningDate, DateTime ejoningTime);

        public List<Student> PostR(int myid, string myname, string mydepartment, int myage, DateTime myjoiningDate);
        public List<Student> PutR(int id, string myname, string mydepartment, int myage, DateTime myjoiningDate);

        public List<Student> DeleteR(int id);

    }
}
