using AutoMapper;
using BLL.interfaces;
using DAL.function;
using DAL.interfaces;
using DAL.models;
using DTO;
using DTO.respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.function
{
    public class userBLL : IuserBLL
    {
        static IMapper _Mapper;
        IuserDAL _IuserDAL;
        public userBLL(IuserDAL i)
        {
            _IuserDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofile>();
            });
            _Mapper = config.CreateMapper();
        } 

        public bool add(UserDTO user)
        {
            try
            {
         
             _IuserDAL.add(_Mapper.Map<UserDTO, User>(user));
                return true;
            }
            catch
            {
                return false;   
            }
        }

        public List<UserDTO> getall()
        {
            List<User> list = _IuserDAL.getall();
            return _Mapper.Map<List<User>,List<UserDTO>>(list);
        }

        public UserDTO getuserbymailandpass(string mail, string pass)
        {
          User user = _IuserDAL.getall().FirstOrDefault(a=>a.UserName== mail&&a.Password==pass);
           return _Mapper.Map< User, UserDTO>(user);
        }
    }
}
