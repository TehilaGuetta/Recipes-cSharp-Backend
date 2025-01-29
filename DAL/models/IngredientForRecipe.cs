using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class IngredientForRecipe
    {
        public int CodeIngredientRecipe { get; set; }
        public int? CodeRecipe { get; set; }
        public int? CodeIngredient { get; set; }
        public string? Amount { get; set; }

        public virtual Ingedient? CodeIngredientNavigation { get; set; }
        public virtual RecipeTable? CodeRecipeNavigation { get; set; }
    }
}
