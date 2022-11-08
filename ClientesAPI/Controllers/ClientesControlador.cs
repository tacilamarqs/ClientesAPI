using Azure.Core;
using ClientesAPI.Data;
using ClientesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;


namespace ClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesControlador : ControllerBase
    {
        private readonly DataContext _context;

        public ClientesControlador(DataContext context) {
            
            _context = context;
        }


        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetClientesId), new { Id = cliente.Id }, cliente);
        }

        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Clientes;
        }


        [HttpGet("{id}")]
        public IActionResult GetClientesId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, [FromBody] Cliente clienteNovo)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }


            cliente.Nome = clienteNovo.Nome;
            cliente.Telefone = clienteNovo.Telefone;
            cliente.DataNascimento = clienteNovo.DataNascimento;
            cliente.ValorUltimaCompra = clienteNovo.ValorUltimaCompra;
            cliente.ValorTotalCompras = clienteNovo.ValorTotalCompras;

            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete]
        public IActionResult DeletarCliente(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
