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
    public class recipeTableDAL : IrecipeTableDAL
    {
        recipe_thContext _recipe_thContext;
        public recipeTableDAL(recipe_thContext recipe_thContext)
        {
            _recipe_thContext = recipe_thContext;
        }

        public bool add(RecipeTable RecipeTable)
        {
            try
            {
                _recipe_thContext.Add(RecipeTable);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<RecipeTable> getall()
        {
            return _recipe_thContext.RecipeTables.Include(e=>e.IdUserNavigation).ToList();
        }

        public bool remove(RecipeTable RecipeTable)
        {
            try
            {
                _recipe_thContext.Remove(RecipeTable);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool update(RecipeTable RecipeTable, int CodeRecipe)
        {
           try
            {
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).LevelRecipe = RecipeTable.LevelRecipe;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe). Name= RecipeTable.Name;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).Time = RecipeTable.Time;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).Descrebtion = RecipeTable.Descrebtion;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).Count = RecipeTable.Count;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).Instraction = RecipeTable.Descrebtion;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).IdUser = RecipeTable.IdUser;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).Img = RecipeTable.Img;
                _recipe_thContext.RecipeTables.FirstOrDefault(i => i.CodeRecipe == CodeRecipe).CodeRecipe = RecipeTable.CodeRecipe;
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
