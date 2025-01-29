using BLL.interfaces;
using DAL.models;
using DTO.respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace recipe_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        IuserBLL _IuserBLL;
       public userController(IuserBLL IuserBLL)
        {
            _IuserBLL = IuserBLL;
        }
        [HttpGet("getall")]
        public ActionResult<List<User>> getall()
        {
            return Ok(_IuserBLL.getall());
        }
        [HttpGet("getbymailandpass/{mail}/{pass}")]
        public ActionResult<User> getbymailandpass(string mail,string pass)
        {
            return Ok(_IuserBLL.getuserbymailandpass(mail, pass));
        }
        [HttpPost("add")]
        public ActionResult<bool> add(UserDTO userDTO)
        {
            return Ok(_IuserBLL.add(userDTO));
        }


    }
}
