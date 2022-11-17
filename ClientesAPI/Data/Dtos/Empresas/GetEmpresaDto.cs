namespace ClientesAPI.Data.Dtos.Empresas
{
    public class GetEmpresaDto
    {
        public int EmpresaId { get; set; }
        public string NomeEmpresa { get; set; } 
        public string Filial { get; set; } 

        public object Clientes { get; set; }
    }
}
