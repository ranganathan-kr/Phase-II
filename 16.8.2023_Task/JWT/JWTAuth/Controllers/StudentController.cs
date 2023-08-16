using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var student = await _student.GetAllStudents();
            if (student == null)
            {
                return NotFound("npooo");
            }
            return Ok(student);

        }

        [HttpGet("{Rollno}")]
        public async Task<ActionResult<Student>> GetStudentById(int Rollno)
        {

            try
            {
                var student = await _student.GetStudentById(Rollno);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }


        }

        [HttpPost]

        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            try
            {
                var students = await _student.AddStudent(student);
                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
        [HttpPut]

        public async Task<ActionResult<Student>> UpdateStudent(int Rollno, Student student)
        {
            try
            {
                var students = await _student.UpdateStudent(Rollno, student);
                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {

            try
            {
                var student = await _student.DeleteStudent(rollno);
                return Ok(student);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
