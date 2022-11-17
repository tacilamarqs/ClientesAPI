using AutoMapper;
using ClientesAPI.Data.Dtos.Empresas;
using ClientesAPI.Models;

namespace ClientesAPI.Profiles
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<CriarEmpresaDto, Empresa>();
            CreateMap<Empresa, GetEmpresaDto>();
        }
    }
}
