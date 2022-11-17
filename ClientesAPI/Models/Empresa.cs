using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClientesAPI.Models
{
    public class Empresa
    {
        [Key]
        [Required]
        public int EmpresaId { get; set; }
        public string NomeEmpresa { get; set; } 
        public string Filial { get; set; } 
        [JsonIgnore]
        public List<Cliente> Clientes { get; set; }

    }
}
