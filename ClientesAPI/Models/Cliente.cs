using System.ComponentModel.DataAnnotations;

namespace ClientesAPI.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
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

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
