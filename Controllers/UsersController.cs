using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_JWT_Authorize.Models;

namespace WebAPI_JWT_Authorize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            List<Users> users= new List<Users>() { 
                new Users { Id=1, Email="abc@gmail.com", Password="abc123", UserName="abc" },
                 new Users { Id=2, Email="abcd@gmail.com", Password="abc123", UserName="abcd" },
                  new Users { Id=3, Email="abcde@gmail.com", Password="abc123", UserName="abcde" },
                   new Users { Id=4, Email="abcdef@gmail.com", Password="abc123", UserName="abcdef" },
            };

            return Ok(users);
        }

        [AllowAnonymous]
        [HttpGet("GetUnAuthUsers")]
        public string GetUnAuth()
        {
            return "Unauthorize Access for Users";
        }

    }
}
