using AutoMapper;
using DAL.models;
using DTO.respository;

namespace DTO
{
    public class myprofile: Profile
    {
        public myprofile()
        {
            CreateMap<IngedientDTO, Ingedient>();
            CreateMap<Ingedient,IngedientDTO >();

            CreateMap<IngredientForRecipe, IngredientForRecipeDTO>().ForMember(a => a.IngedientName, j => j.MapFrom(w => w.CodeIngredientNavigation.IngedientName));
            CreateMap<IngredientForRecipeDTO, IngredientForRecipe>();


            CreateMap<RecipeTable, RecipeTableDTO>().ForMember(a => a.Email, r => r.MapFrom(e => e.IdUserNavigation.Email))
                .ForMember(a=>a.Family,e=>e.MapFrom(r=>r.IdUserNavigation.Family))
                .ForMember(w=>w.UserName,e=>e.MapFrom(r=>r.IdUserNavigation.UserName))
                .ForMember(a => a.Password, e => e.MapFrom(r => r.IdUserNavigation.Password));
            CreateMap<RecipeTableDTO, RecipeTable>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

        }


    }
}