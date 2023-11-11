using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        //[Authorize(Roles = "admin,user.all,user.list")]
       

        //[Authorize(Roles = "admin,user.all,user.list")]
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _userService.GetUserDtoById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       

        //[Authorize(Roles = "admin,user.all,user.update")]
        [HttpPost("update")]
        public IActionResult Update(UserDto user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}