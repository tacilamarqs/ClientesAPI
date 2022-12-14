using System.ComponentModel.DataAnnotations;

namespace ClientesAPI.Data.Dtos.Clientes
{
    public class CriarClienteDto
    {
        
        [Required(ErrorMessage = "O nome do cliente é obrigatório!")]
        public string Nome { get; set; } 
        [Required(ErrorMessage = "O número de telefone do cliente é obrigatório!")]
        [StringLength(14)]
        public string Telefone { get; set; } 
        public string DataNascimento { get; set; }
        public string DataUltimaCompra { get; set; } 
        public double ValorUltimaCompra { get; set; }
        [Required]
        public double ValorTotalCompras { get; set; }
        public int EmpresaId { get; set; }


    }
}
