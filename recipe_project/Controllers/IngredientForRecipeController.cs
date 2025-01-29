using BLL.interfaces;
using DAL.models;
using DTO.respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace recipe_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientForRecipeController : ControllerBase
    {
        IingredientForRecipeBLL _IingredientForRecipeBLL;
        public IngredientForRecipeController(IingredientForRecipeBLL iingredientForRecipeBLL)
        {
            _IingredientForRecipeBLL = iingredientForRecipeBLL;
        }
        [HttpGet("getall")]
        public ActionResult<List<IngredientForRecipe>> getall()
        {
            return Ok(_IingredientForRecipeBLL.getall());
        }
        [HttpGet("getingredientbycode/{code}")]
        public ActionResult<List<IngredientForRecipe>> getingredientbycode(int code)
        {
            return Ok(_IingredientForRecipeBLL.getingredientbycode(code));
        }
        [HttpPost("addlistingredient")]
        public ActionResult <bool> addlistingredient(List<IngredientForRecipeDTO> list)
        {
            return Ok(_IingredientForRecipeBLL.addlistingredient(list));
        }
        [HttpPost("add")]
        public ActionResult<bool> add(IngredientForRecipeDTO s)
        {
            return Ok(_IingredientForRecipeBLL.add(s));
        }
    }
}
