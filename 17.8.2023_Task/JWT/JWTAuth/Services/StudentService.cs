using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Global_Exception;

namespace JWTAuth.Services
{
    public class StudentService : IStudent
    {
        public StudentManagementContext _studentContext;

        public StudentService(StudentManagementContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();
        }

        public async Task<Student> DeleteStudent(int Rollno)
        {
            Student student = await _studentContext.Students.FindAsync(Rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsException.MyException[0]);
            }
            else
            {
                _studentContext.Remove(student);
                await _studentContext.SaveChangesAsync();

                return student;
            }
        }


        public async Task<List<Student>> GetAllStudents()
        {
            var responce = await _studentContext.Students.ToListAsync();
            return responce;

        }

        public async Task<Student> GetStudentById(int Rollno)
        {
            var student = await _studentContext.Students.FindAsync(Rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsException.MyException[0]);
            }
            else
            {
                return student;
            }

        }

        public async Task<Student> UpdateStudent(int Rollno, Student student)
        {
            Student? rstudent = await _studentContext.Students.FindAsync(Rollno, student);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsException.MyException[0]);
            }
            else
            {
                rstudent.Studname = student.Studname;
                rstudent.Addr = student.Addr;
                rstudent.Phno = student.Phno;
                await _studentContext.SaveChangesAsync();

                return await _studentContext.Students.FindAsync(Rollno, student);
            }
        }

    }
}
