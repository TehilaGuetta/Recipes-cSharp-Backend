
using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class ingredientForRecipeDAL : IingredientForRecipeDAL
    {
        recipe_thContext _recipe_thContext;
        public ingredientForRecipeDAL(recipe_thContext recipe_thContext)
        {
            _recipe_thContext = recipe_thContext;
        }

        public bool add(IngredientForRecipe IngredientForRecipe)
        {
            try
            {
                _recipe_thContext.Add(IngredientForRecipe);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public List<IngredientForRecipe> getall()
        {
            return _recipe_thContext.IngredientForRecipes.Include(e=>e.CodeIngredientNavigation).ToList();
        }

        public bool remove(IngredientForRecipe IngredientForRecipe)
        {
            try
            {
                _recipe_thContext.Remove(IngredientForRecipe);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
