using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IingredientDAL
    {
        List<Ingedient> getall();
        int add(Ingedient ingedient);
        bool remove(Ingedient ingedient);


    }
}
