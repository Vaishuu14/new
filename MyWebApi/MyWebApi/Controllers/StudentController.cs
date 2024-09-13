using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("all")]
        public IEnumerable<Student> GetAllStudents()
        {
            return StudentConfigure.students;

        }


        [HttpGet("id")]
        public Student GetStudentById(int id)
        {
            var result = StudentConfigure.students.Where(x => x.Id == id).FirstOrDefault();

            return result;

        }

        [HttpGet("name")]
        public Student GetStudentByName(string name)
        {
            var result = StudentConfigure.students.Where(x => x.Name == name).FirstOrDefault();

            return result;
        }


        [HttpDelete("id")]
        public bool DeleteStudentById(int id)
        {
            var student = StudentConfigure.students.Where(x => x.Id == id).FirstOrDefault();

            StudentConfigure.students.Remove(student);

            return true;

        }



    }
}
