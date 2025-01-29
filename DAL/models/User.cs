using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class User
    {
        public User()
        {
            RecipeTables = new HashSet<RecipeTable>();
        }

        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Family { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<RecipeTable> RecipeTables { get; set; }
    }
}
