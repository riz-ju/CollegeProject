using CollegeProjectModels.Models;
using CollegeProjectRepository.Interface;
using CollegeProjectServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectServices.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studenRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studenRepository = studentRepository;
        }
        public List<Student> DeleteS(int id)
        {
            return _studenRepository.DeleteR(id);
        }

        public List<Student> GetByAgeS(int age)
        {
            return _studenRepository.GetByAgeR(age);
        }

        public List<Student> GetByIdS(int id)
        {
            return _studenRepository.GetByIdR(id);
        }

        public dynamic GetByjoiningDateS(DateTime joningDate, DateTime ejoningTime)
        {
            return _studenRepository.GetByjoiningDateR(joningDate, ejoningTime);
        }

        public List<Student> GetByNameS(string name)
        {
            return _studenRepository.GetByNameR(name);
        }

        public List<Student> GetS()
        {
           return _studenRepository.GetR();
        }

        public List<Student> PostS(int myid, string myname, string mydepartment, int myage, DateTime myjoiningDate)
        {
            return _studenRepository.PostR(myid, myname, mydepartment, myage, myjoiningDate);
        }

        public List<Student> PutS(int id, string myname, string mydepartment, int myage, DateTime myjoiningDate)
        {
            return _studenRepository.PutR(id, myname, mydepartment,myage, myjoiningDate);
        }
    }
}
