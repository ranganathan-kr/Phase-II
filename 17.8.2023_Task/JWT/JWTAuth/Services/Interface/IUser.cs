using JWTAuth.Models;

namespace JWTAuth.Services.Interface
{
    public interface IUser
    {
        public Task<User> GetUserByUserName(string userName);

        Task<List<User>> AddUser(User user);

        Task<User> UpdateUser(String username, User user);

        Task<List<User>> DeleteUser(String username);
    }
}
