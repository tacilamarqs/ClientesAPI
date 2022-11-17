using AutoMapper;
using ClientesAPI.Data.Dtos.Clientes;
using ClientesAPI.Models;

namespace ClientesAPI.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            CreateMap<CriarClienteDto, Cliente>();
            CreateMap<Cliente, GetClienteDto>();
            CreateMap<AtualizarClienteDto, Cliente>();
        }
    }
}
