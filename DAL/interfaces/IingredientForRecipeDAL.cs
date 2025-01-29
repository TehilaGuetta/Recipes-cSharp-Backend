using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IingredientForRecipeDAL
    {
        List<IngredientForRecipe> getall();
        bool add(IngredientForRecipe IngredientForRecipe);
        bool remove(IngredientForRecipe IngredientForRecipe);
    }
}
