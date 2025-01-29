using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class userDAL : IuserDAL
    {
        recipe_thContext _recipe_thContext;
        public userDAL(recipe_thContext recipe_thContext)
        {
            _recipe_thContext = recipe_thContext;
        }
        //add
        public bool add(User User)
        {
            try
            {
                _recipe_thContext.Add(User);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
        //getall
        public List<User> getall()
        {
            return _recipe_thContext.Users.ToList();
        }
        //remove
        public bool remove(User User)
        {
            try
            {
                _recipe_thContext.Remove(User);
                _recipe_thContext.SaveChanges();
                return true;
            }
            catch 
            {

                return false;   
            }
        }
        //update
        public bool update(User User, int Id)
        {
            try
            {
                _recipe_thContext.Users.FirstOrDefault(i=>i.Id==Id).Family=User.Family;
                _recipe_thContext.Users.FirstOrDefault(i=>i.Id==Id).Email=User.Email;
                _recipe_thContext.Users.FirstOrDefault(i => i.Id == Id).UserName = User.UserName;
                _recipe_thContext.Users.FirstOrDefault(i => i.Id == Id).Id = User.Id;
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
