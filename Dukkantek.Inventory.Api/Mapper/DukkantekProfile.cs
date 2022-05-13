using AutoMapper;
using Dukkantek.Inventory.Application.Categories.Commands;
using Dukkantek.Inventory.Application.Categories.Models.Result;
using Dukkantek.Inventory.Domain.Categories;

namespace Dukkantek.Inventory.Api.Mapper
{
    public class DukkantekProfile : Profile
    {
        public DukkantekProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, GetCategoryQueryResult>()
                .ForMember(e => e.Products, opt => opt.MapFrom(s => s.Products.Count));
        }
    }
}
