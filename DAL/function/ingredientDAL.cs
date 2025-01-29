using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class ingredientDAL : IingredientDAL
    {
        recipe_thContext _recipe_thContext;
        public ingredientDAL(recipe_thContext recipe_thContext)
        {
            _recipe_thContext = recipe_thContext;
        }

        public int add(Ingedient ingedient)
        {
            try
            {
                _recipe_thContext.Add(ingedient);
                _recipe_thContext.SaveChanges();
                return ingedient.Id;
            }
            catch 
            {

                return -1;
            }
        }

        public List<Ingedient> getall()
        {
            return _recipe_thContext.Ingedients.ToList();
        }

        public bool remove(Ingedient ingedient)
        {
            try
            {
                _recipe_thContext.Remove(ingedient);
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
