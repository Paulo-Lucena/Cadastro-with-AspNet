using AutoMapper;
using LucenaSolutions.Intern.APICadastro.Web.Models;

namespace LucenaSolutions.Intern.APICadastro.Web.DTOs.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        }
    }
}
