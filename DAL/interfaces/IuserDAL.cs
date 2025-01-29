using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IuserDAL
    {
        List<User> getall();
        bool add(User User);
        bool remove(User User);
        bool update(User User, int Id);
    }
}
