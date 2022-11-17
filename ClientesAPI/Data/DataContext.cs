using ClientesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .HasOne(cliente => cliente.Empresa)
                .WithMany(empresa => empresa.Clientes)
                .HasForeignKey(cliente => cliente.EmpresaId);
        }
        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<Empresa>? Empresas { get; set; }
    }
}
