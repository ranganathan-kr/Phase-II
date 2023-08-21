using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;
        private IToken _token;

        public UserController(IUser user,IToken token)
        {
            _user = user;
            _token = token;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetUserByUserName (string username)
        {
            try
            {
                var user = await _user.GetUserByUserName(username);
                var token = _token.GenerateToken(user.Username, user.Role);
                Console.WriteLine(token);
                return Ok(token);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            return Ok(await _user.AddUser(user));

        }

        [HttpDelete]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<List<User>>> DeleteUser(string username)
        {
            try
            {
                var user=  await _user.DeleteUser(username);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(string user,User newUser)
        {
            try
            {
                var ruser = await _user.UpdateUser(user,newUser);
                return Ok(ruser);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
            
    }
}
