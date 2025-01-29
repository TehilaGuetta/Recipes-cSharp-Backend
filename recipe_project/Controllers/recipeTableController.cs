using BLL.interfaces;
using DAL.models;
using DTO.respository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace recipe_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class recipeTableController : ControllerBase
    {
        IrecipeTableBLL _IrecipeTableBLL;
        public recipeTableController(IrecipeTableBLL irecipeTableBLL)
        {
            _IrecipeTableBLL = irecipeTableBLL;
        }
        [HttpGet("getall")]
        public ActionResult<List<RecipeTableDTO>> getall()
        {
            return Ok(_IrecipeTableBLL.getall());
        }
        [HttpPost("add")]
        public ActionResult<int> addrecipe(RecipeTableDTO recipeTableDTO)
        {
            return Ok(_IrecipeTableBLL.add(recipeTableDTO));
        }
        [HttpGet("getbycode/{id}")]
        public ActionResult<RecipeTableDTO> getbyuser(int id)
        {
            return Ok(_IrecipeTableBLL.getbyusercode(id));
        }
            
    }
}
