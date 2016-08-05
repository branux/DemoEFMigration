using DemoMigrations.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMigrations.Infra
{
    public class ClientesContexto:DbContext
    {
        public ClientesContexto():base("DemoMigrationsConn")
        {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresa { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EmpresaMap());

        }

    }
}
