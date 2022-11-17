using AutoMapper;
using ClientesAPI.Data;
using ClientesAPI.Data.Dtos.Empresas;
using ClientesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasControlador : ControllerBase
    {
        private readonly DataContext _context;
        private IMapper _mapper;

        public EmpresasControlador(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaEmpresa(CriarEmpresaDto empresaDto)
        {
            Empresa empresa = _mapper.Map<Empresa>(empresaDto);

            _context.Empresas.Add(empresa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEmpresaId), new { Id = empresa.EmpresaId }, empresa);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpresaId(int id)
        {
            Empresa empresa = _context.Empresas.FirstOrDefault(empresa => empresa.EmpresaId == id);
            if (empresa != null)
            {
                GetEmpresaDto empresaDto = _mapper.Map<GetEmpresaDto>(empresa);
                return Ok(empresa);
            }
            return NotFound();
        }


    }
}
