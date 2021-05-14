using Anuncios.Data.Map;
using Anuncios.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Anuncios.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Anuncio> Anuncio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnuncioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
