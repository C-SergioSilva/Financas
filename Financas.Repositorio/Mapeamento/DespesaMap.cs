using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {

            builder.ToTable("Despesa");
            builder.HasQueryFilter(u => !u.Deletado);
            builder.HasKey(u => u.IdDespesa);
            builder.Property(u => u.DataCriacao);
            builder.HasOne(d => d.TipoPagamento).WithMany(d => d.Despesas).HasForeignKey(d => d.IdTipoPagamento);
            builder.HasOne(u => u.Usuario).WithMany(p => p.Despesas).HasForeignKey(u => u.IdUsuario);

        }
    }
}
