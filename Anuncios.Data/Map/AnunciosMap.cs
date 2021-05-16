using Anuncios.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anuncios.Data.Map
{
    public class AnuncioMap : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.ToTable("Anuncio");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeAnuncio)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Cliente)
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.DataInicio)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.DataFim)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(x => x.InvestDia)
                .HasColumnType("float")
                .IsRequired();

            builder.Property(x => x.InvestTotal)
                .HasColumnType("float");

            builder.Property(x => x.MaxVisualizacao)
                .HasColumnType("float");

            builder.Property(x => x.MaxCliques)
            .HasColumnType("float");

            builder.Property(x => x.MaxComp)
                .HasColumnType("float");
        }
    }
}
