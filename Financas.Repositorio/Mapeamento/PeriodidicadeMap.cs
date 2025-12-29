using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class PeriodidicadeMap : IEntityTypeConfiguration<Periodicidade>
    {
        public void Configure(EntityTypeBuilder<Periodicidade> builder)
        {
            builder.ToTable("Periodicidade");
            builder.HasKey(p => p.IdPeriodicidade);
            builder.HasMany(p => p.Balancetes).WithOne(p => p.Periodicidade).HasForeignKey(p => p.IdPeriodicidade);
        }
    }
}
