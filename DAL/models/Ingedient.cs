using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Ingedient
    {
        public Ingedient()
        {
            IngredientForRecipes = new HashSet<IngredientForRecipe>();
        }

        public int Id { get; set; }
        public string? IngedientName { get; set; }

        public virtual ICollection<IngredientForRecipe> IngredientForRecipes { get; set; }
    }
}
