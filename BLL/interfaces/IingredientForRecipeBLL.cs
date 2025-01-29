using DAL.models;
using DTO.respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IingredientForRecipeBLL
    {
        List<IngredientForRecipeDTO> getall();
        List<IngredientForRecipeDTO> getingredientbycode(int recipeid);
        bool addlistingredient(List<IngredientForRecipeDTO> list);
        bool add(IngredientForRecipeDTO s);
    }
}
