using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Global_Exception;
using System.Linq;

namespace JWTAuth.Services
{
    public class UserService : IUser
    {
        private StudentManagementContext _student;

        public UserService(StudentManagementContext student)
        {
            _student = student;
        }

        public async Task<List<User>> AddUser(User user)
        {
            _student.Users.Add(user);
            await _student.SaveChangesAsync();
            return await _student.Users.ToListAsync();

        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var ruser = await _student.Users.FindAsync(username);
            if (ruser != null)
            {
                _student.Users.Remove(ruser);
                await _student.SaveChangesAsync();
                return await _student.Users.ToListAsync();
            }
            else
            {
                throw new Exception(StudentDetailsException.MyException[0]);
            }
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            var user = await _student.Users.FindAsync(userName);
            return user;
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var ruser = await _student.Users.FindAsync(username);
            if (ruser == null)
            {
                throw new Exception(StudentDetailsException.MyException[0]);
            }
            else
            {
                ruser.Password = user.Password;
                ruser.Role=user.Role;
                await _student.SaveChangesAsync();
                return ruser;
            }
            
            
        }
    }
}
