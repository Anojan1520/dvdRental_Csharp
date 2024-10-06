using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO.Request;
using WebApplication1.Service;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("User")]
        public IActionResult Register(UserRequest users)
        {
            try
            {
                var ReturnData = userService.Register(users);
                return Ok(ReturnData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("User")]
        public IActionResult GetAll()
        {
            try
            {
                var data = userService.GetAllUser();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("User")]
        public IActionResult UpdateUser(UserRequest user, Guid id)
        {
            try
            {
                var data = userService.UpdateUser(user, id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("User")]
        public IActionResult DeleteUser(Guid id)
        {
            try
            {
                var data = userService.DeleteUser(id);
                return Ok(data);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message) ;
            }
        }
    }
}
