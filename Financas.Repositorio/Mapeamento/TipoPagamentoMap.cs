using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class TipoPagamentoMap : IEntityTypeConfiguration<TipoPagamento>
    {
        public void Configure(EntityTypeBuilder<TipoPagamento> builder)
        {

            builder.ToTable("TipoPagamento");
            builder.HasQueryFilter(u => !u.Deletado);
            builder.HasKey(u => u.IdTipoPagamento);
            builder.Property(u => u.DataCriacao);
            builder.HasMany(t => t.Despesas).WithOne(t => t.TipoPagamento).HasForeignKey(t => t.IdTipoPagamento);
        }
    }
}
