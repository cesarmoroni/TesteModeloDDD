
using System.Data.Entity.ModelConfiguration;
using TesteModeloDDD.Domain.Entities;

namespace TesteModeloDDD.Infra.Data.EntityConfig
{
    class CategoriaConfiguration: EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(c => c.CategoriaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Ativo)
                .IsRequired();

            
        }
    }
}
