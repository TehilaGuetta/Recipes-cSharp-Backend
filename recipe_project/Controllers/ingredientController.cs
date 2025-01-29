using BLL.interfaces;
using DAL.models;
using DTO.respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace recipe_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ingredientController : ControllerBase
    {
        IingredientBLL _IingredientBLL;
        public ingredientController(IingredientBLL iingredientBLL)
        {
            _IingredientBLL = iingredientBLL;
        }
        [HttpGet("getall")]
        public ActionResult <List<Ingedient>> getall()
        {
            return Ok(_IingredientBLL.getall());
        }
        [HttpPost("add")]
        public ActionResult<int>add(IngedientDTO IngedientDTO)
        {
            return Ok(_IingredientBLL.add(IngedientDTO));
        }
    }
}
