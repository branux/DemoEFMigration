using DemoMigrations.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMigrations.Infra
{
    public class ClienteMap:EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(c=>c.Id);


            Property(col => col.Id).HasColumnName("Id").HasColumnType("int")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(c => c.Sexo).HasColumnName("Sexo").HasColumnType("int").IsRequired();
            Property(c => c.EmpresaId).HasColumnName("EmpresaId").HasColumnType("int");
            Property(c => c.Nascimento).HasColumnName("Nascimento").HasColumnType("datetime");


            HasOptional(s => s.Empresa)
                .WithMany(s => s.Clientes)
                .HasForeignKey(s => s.EmpresaId);

        }

    }
}
