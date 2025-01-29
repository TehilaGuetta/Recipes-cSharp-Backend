using DAL.models;
using DTO.respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IuserBLL
    {
        List<UserDTO> getall();
        UserDTO getuserbymailandpass(string mail, string pass);
        bool add(UserDTO user);
    }
}
