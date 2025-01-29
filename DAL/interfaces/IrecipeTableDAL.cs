using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IrecipeTableDAL
    {
        List<RecipeTable> getall();
        bool add(RecipeTable RecipeTable);
        bool remove(RecipeTable RecipeTable);
        bool update(RecipeTable RecipeTable, int CodeRecipe);
    }
}
