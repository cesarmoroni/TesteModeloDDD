
using System.Data.Entity.ModelConfiguration;
using TesteModeloDDD.Domain.Entities;

namespace TesteModeloDDD.Infra.Data.EntityConfig
{
    class LivroConfiguration: EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(c => c.LivroId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);


            Property(c => c.Isbn)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.QtdeEstoque)
                .IsRequired();

            Property(c => c.Autor)
                .HasMaxLength(150);

            HasRequired(p => p.Categoria)
             .WithMany()
             .HasForeignKey(p => p.CategoriaId);

        }
    }
}
