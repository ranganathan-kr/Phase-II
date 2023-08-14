using StudentDetails.Model;

namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {

         Task <List<Student>> GetAllStudents();

         Task<Student> GetStudentById(int id);

         Task<List<Student>> AddStudent(Student student);
         Task<Student> UpdateStudent(int Rollno,Student student);
         Task<Student> DeleteStudent(int Rollno);

    }
}
