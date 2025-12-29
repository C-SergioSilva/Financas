using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class FonteRendaMap : IEntityTypeConfiguration<FonteRenda>
    {
        public void Configure(EntityTypeBuilder<FonteRenda> builder)
        {

            builder.ToTable("FonteRenda");
            builder.HasQueryFilter(u => !u.Deletado);
            builder.HasKey(u => u.IdFonteRenda);
            builder.Property(u => u.DataCriacao);
            builder.HasMany(t => t.Receitas).WithOne(t => t.FonteRenda).HasForeignKey(t => t.IdFonteRenda);

        }

    }
}
