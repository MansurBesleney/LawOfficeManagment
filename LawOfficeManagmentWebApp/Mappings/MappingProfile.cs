using AutoMapper;
using LawOfficeManagmentWebApp.Models.Dtos;
using LawOfficeManagmentWebApp.Models.Entites;

namespace LawOfficeManagmentWebApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
        }
    }
}
