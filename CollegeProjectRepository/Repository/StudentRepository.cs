using AutoMapper;
using CollegeProjectData;
using CollegeProjectModels.Models;
using CollegeProjectRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectRepository.Repository
{


    public class StudentRepository : IStudentRepository
    {
        public List<Student> student = new List<Student>();
        private readonly IMapper _mapper;
        public StudentRepository(IMapper mapper)
        {
            _mapper = mapper;


        }

        
        public List<Student> DeleteR(int id)
        {
            /*  var students = student[id - 1];
              student.Remove(students);
              return student.ToList();*/

            using (var db = new ApiDbContext())
            {

                var dbWork = db.students.Where(x => x.Sid == id).FirstOrDefault();
                db.students.Remove(dbWork);
                db.SaveChanges();

            }
                return student;
        }

        public List<Student> GetByAgeR(int age)
        {
            //var data = from sage in student where sage.age <= age select sage;
            //return data;
            var db = new ApiDbContext();    
            var udata = db.students.Where(x=>x.Sage == age).ToList();
            var vudata = _mapper.Map<List<Student>>(udata);
            return vudata;
        }

        public List<Student> GetByIdR(int id)
        {
            // var data = from sid in student where sid.id == id select sid;
            //return data;
            var db = new ApiDbContext();
            var udata = db.students.Where(x => x.Sid == id).ToList();
            var vudata = _mapper.Map<List<Student>>(udata);
            return vudata;
        }

        public dynamic GetByjoiningDateR(DateTime joningDate, DateTime ejoningTime)
        {
            //var data = from jdate in student where (jdate.joiningDate >= joningDate && jdate.joiningDate <= ejoningTime) select jdate;
            // return data;
            var db = new ApiDbContext();
           // var data = from jdate in db.students where (jdate.SjoiningDate >= joningDate && jdate.SjoiningDate <= ejoningTime) select jdate;
            var udata = db.students.Where(x => x.SjoiningDate >= joningDate &&  x.SjoiningDate <= ejoningTime);
            var vudata = _mapper.Map<List<Student>>(udata);
            return vudata;

        }

        public List<Student> GetByNameR(string name)
        {
            //var data = from sname in student where sname.name == name select sname;
            //return data;
            var db = new ApiDbContext();
            var udata = db.students.Where(x => x.Sname == name).ToList();
            var vudata = _mapper.Map<List<Student>>(udata);
            return vudata;
        }
       /* [HttpGet()]
        public dynamic GetRbydb("diff")
        {
            var db = new ApiDbContext();

            var stRecords = db.students;
            return stRecords.Select(x => x.Sid).ToList();

        }*/

        public List<Student> GetR()
        {
           //testDbContext();
            //return student;
            var db = new ApiDbContext();
            var result =  db.students.ToList();
            var excResult = _mapper.Map<List<Student>>(result);
            return excResult;
        }

        public List<Student> PostR(int myid, string myname, string mydepartment, int myage, DateTime myjoiningDate)
        {
            using (var db = new ApiDbContext())
            {
                var stRecords = db.students.ToList();
               db.students.Add(new Students() { Sage = myage, Sid = myid, Sdepartment = mydepartment, SjoiningDate =myjoiningDate, Sname = myname });
               db.SaveChanges();
                // student.Add(stRecords);


            }

            // student.Add(new Student() { id = myid, name = myname, department = mydepartment, age = myage, joiningDate = myjoiningDate });
            return student;

        }

        public List<Student> PutR(int id, string myname, string mydepartment, int myage, DateTime myjoiningDate)
        {
            using (var db = new ApiDbContext())
            {
                //var stRecords = db.students.ToList();
                var dbWork = db.students.Where(x=>x.Sid == id).Select(x=>x).FirstOrDefault();
                //db.students.Where(x => x.Sid == id).Select(x => x).FirstOrDefault().Add(new Students() { Sage = myage, Sid = id, Sdepartment = mydepartment, SjoiningDate = myjoiningDate, Sname = myname });
                dbWork.Sid = id;
                dbWork.Sage = myage;
                dbWork.Sdepartment = mydepartment;
                dbWork.Sname = myname;
                dbWork.SjoiningDate = myjoiningDate;
                db.SaveChanges();
                // student.Add(stRecords);


            }
            /* student[id - 1].name = myname;
             student[id - 1].department = mydepartment;
             student[id - 1].age = myage;
             student[id - 1].joiningDate = myjoiningDate;
             student[id - 1].id = id;
             return student.ToList();*/
            return student;

        }

      /*  public void testDbContext()
        {
            using (var db = new ApiDbContext())
            {
                var stRecords = db.students.ToList();
             // student.Add(stRecords);


            }

        }*/

    }
}