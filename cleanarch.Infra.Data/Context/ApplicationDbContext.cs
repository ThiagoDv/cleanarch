using cleanarch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace cleanarch.Infra.Data.Context
{
    /// <summary>
    /// CLASSE RESPONSÁVEL POR CRIAR O CONTEXTO E RELAÇÃO NO BANCO DE DADOS.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
