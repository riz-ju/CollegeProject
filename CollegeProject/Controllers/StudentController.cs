
using AutoMapper;
using CollegeProjectData;
using CollegeProjectModels.Models;
using CollegeProjectServices.Interface;
using CollegeProjectServices.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mappper)
        {
            _mapper = mappper;
            _studentService = studentService;
        }
       
       
        
       //public  List<Student> students = new List<Student>();

        
       

        
        // GET: api/<StudentController>
        [HttpGet()]
        public List<Student> Get()
        {
            return _studentService.GetS();
            //return students.ToList();
        }



        // GET api/<StudentController>/5
        [HttpGet("st/{id}")]
        public List<Student> GetById(int id)
        {
           return _studentService.GetByIdS(id);
            /*var data = from sid in students where sid.id == id select sid;
            return data;*/
            
        }


        // GET api/<StudentController>/5
        [HttpGet("s/{name}")]
        public List<Student> GetbyName(string name)
        {
            return _studentService.GetByNameS(name);
            /*var data = from sname in students where sname.name == name select sname;
            return data;*/
        }


        [HttpGet("std/{age}")]
        public List<Student> GetbyAge(int age)
        {
            return _studentService.GetByAgeS(age);
            /*var data = from sage in students where sage.age <= age select sage;
            return data;*/
        }

        [HttpGet("joiningDate")]
        public dynamic GetByjoiningDate(DateTime joiningDate, DateTime ejoiningDate)
        {
            return _studentService.GetByjoiningDateS(joiningDate, ejoiningDate);
            /*var data = from jdate in students where (jdate.joiningDate >= joiningDate && jdate.joiningDate <= ejoiningDate) select jdate;
            return data;*/
        }




        // POST api/<StudentController>
        [HttpPost]
        public List<Student> Post(int myid,string myname, string mydepartment, int myage, DateTime myjoiningDate)
        {
            
           return _studentService.PostS(myid,myname,mydepartment,myage,myjoiningDate);
            /*students.Add(new Student() { id = myid, name = myname , department = mydepartment, age = myage, joiningDate = myjoiningDate});
            return students.ToList();*/
        }





        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public List<Student> Put(int id, string myname, string mydepartment,  int myage, DateTime myjoiningDate)
        {
            return _studentService.PutS(id,myname,mydepartment, myage,myjoiningDate);
            /*students[id-1].name = myname;
            students[id - 1].department = mydepartment;
            students[id - 1].age = myage;
            students[id - 1].joiningDate = myjoiningDate;
            return students.ToList();*/
        }



        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public List<Student> Delete(int id)
        {
            return _studentService.DeleteS(id);
            /*var student = students[id-1];
         
            students.Remove(student);
            return students.ToList();*/

        }

        
            


        
    }
}
