using AutoMapper;
using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Models.Entites;

namespace LawOfficeManagementWebApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Lawyer, LawyerDto>().ReverseMap();
        }
    }
}
