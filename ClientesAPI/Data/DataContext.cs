﻿using ClientesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
