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
    public class recipeTableBLL : IrecipeTableBLL
    {
        static IMapper _Mapper;
        IrecipeTableDAL _IrecipeTableDAL;
        public recipeTableBLL(IrecipeTableDAL i)
        {
            _IrecipeTableDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofile>();
            });
            _Mapper = config.CreateMapper();
        }

        public int add(RecipeTableDTO recipeTableDTO)
        {
            try
            {
                RecipeTable rec = _Mapper.Map<RecipeTableDTO, RecipeTable>(recipeTableDTO);
                _IrecipeTableDAL.add(rec);
                return rec.CodeRecipe;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
     

        public List<RecipeTableDTO> getall()
        {
            List<RecipeTable> list =_IrecipeTableDAL.getall();
            return _Mapper.Map<List<RecipeTable>, List<RecipeTableDTO>>(list);
        }

        public List<RecipeTableDTO> getbyusercode(int code)
        {
            List<RecipeTable> list = _IrecipeTableDAL.getall();
            List<RecipeTableDTO> ret = new List<RecipeTableDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IdUser == code)
                    ret.Add(_Mapper.Map < RecipeTable, RecipeTableDTO > (list[i]));
                    
            }
            return ret;
        }
    }
}
