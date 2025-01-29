using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class RecipeTable
    {
        public RecipeTable()
        {
            IngredientForRecipes = new HashSet<IngredientForRecipe>();
        }

        public int CodeRecipe { get; set; }
        public string? Name { get; set; }
        public string? Descrebtion { get; set; }
        public string? LevelRecipe { get; set; }
        public string? Time { get; set; }
        public int? Count { get; set; }
        public string? Instraction { get; set; }
        public int? IdUser { get; set; }
        public string? Img { get; set; }

        public virtual User? IdUserNavigation { get; set; }
        public virtual ICollection<IngredientForRecipe> IngredientForRecipes { get; set; }
    }
}
