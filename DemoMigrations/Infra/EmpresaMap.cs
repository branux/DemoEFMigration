using DemoMigrations.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DemoMigrations.Infra
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("Empresa");

            HasKey(c => c.Id);


            Property(col => col.Id).HasColumnName("Id").HasColumnType("int")
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(c => c.Idade).HasColumnName("Idade").HasColumnType("int");

        }

    }
}
