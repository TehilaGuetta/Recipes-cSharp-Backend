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
    public class ingredientForRecipeBLL : IingredientForRecipeBLL
    {
        static IMapper _Mapper;
        IingredientForRecipeDAL _IingredientForRecipeDAL;
        IingredientDAL _IingredientDAL;

        public ingredientForRecipeBLL(IingredientForRecipeDAL i, IingredientDAL t)
        {
            _IingredientDAL = t;
            _IingredientForRecipeDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofile>();
            });
            _Mapper = config.CreateMapper();
           
        }

        public bool add(IngredientForRecipeDTO s)
        {
            try {
            _IingredientForRecipeDAL.add(_Mapper.Map<IngredientForRecipeDTO, IngredientForRecipe>(s));
            return true; }
            catch { return false; } 
        }

        public bool addlistingredient(List<IngredientForRecipeDTO> list)
        {
            try
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].CodeIngredient == 0)
                    {
                        Ingedient n = new Ingedient() { IngedientName = list[i].IngedientName };
                       int codenew= _IingredientDAL.add(n);
                        list[i].CodeIngredient = codenew;
                    }
                    IngredientForRecipe ing=_Mapper.Map<IngredientForRecipeDTO, IngredientForRecipe>(list[i]);
                    _IingredientForRecipeDAL.add(ing);
                   
                }
                return true;
            }
            catch
            {
                return false;   
            }
        }

        public List<IngredientForRecipeDTO> getall()
         {   
            List<IngredientForRecipe> ls=_IingredientForRecipeDAL.getall();

            return _Mapper.Map<List<IngredientForRecipe>, List<IngredientForRecipeDTO>>(ls);
        }

        public List<IngredientForRecipeDTO> getingredientbycode(int recipeid)
        {
            List<IngredientForRecipe> lt = _IingredientForRecipeDAL.getall().Where(a => a.CodeRecipe == recipeid).ToList();
            return _Mapper.Map<List<IngredientForRecipe>, List<IngredientForRecipeDTO>>(lt);
        }
    }
}
