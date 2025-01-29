using DAL.models;
using DTO.respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IingredientBLL
    {
        List<IngedientDTO> getall();
        int add(IngedientDTO ingredient);
    }
}
