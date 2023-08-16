using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserByName (string username)
        {
            try
            {
                var user = await _user.GetUserByUserName(username);
                return Ok(user);
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
