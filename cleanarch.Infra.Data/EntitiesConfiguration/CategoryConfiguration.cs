using cleanarch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cleanarch.Infra.Data.EntitiesConfiguration
{
    /// <summary>
    /// CLASSE RESPONSÁVEL POR CONFIGURAR AS COLUNAS DA TABELA.
    /// </summary>
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasData(
                new Category(1, "Pet"),
                new Category(2, "Fitness"),
                new Category(3, "Acessórios"));
        }
    }
}
