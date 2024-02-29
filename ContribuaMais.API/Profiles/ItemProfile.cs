using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;

namespace ContribuaMais.API.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<DtoItem, Item>();
            CreateMap<Item, DtoItem>();
        }
    }
}
