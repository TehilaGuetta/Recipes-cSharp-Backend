using AutoMapper;
using BLL.interfaces;
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
    public class ingredientBLL : IingredientBLL
    {
        static IMapper _Mapper;

        IingredientDAL _IingredientDAL;
            public ingredientBLL(IingredientDAL i)
        {
            _IingredientDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofile>();
            });
            _Mapper = config.CreateMapper();
        }

        public int add(IngedientDTO ingredient)
        {
            try
            {
                _IingredientDAL.add(_Mapper.Map<IngedientDTO, Ingedient>(ingredient));
                return ingredient.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }


        public List<IngedientDTO> getall()
        {

            List< Ingedient > ls= _IingredientDAL.getall();
            //return _IingredientDAL.getall();
            return _Mapper.Map<List< Ingedient >,List<IngedientDTO>>(ls);
          
        }
    }
}
