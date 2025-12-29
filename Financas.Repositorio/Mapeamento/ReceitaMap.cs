using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("Receita");
            builder.HasQueryFilter(u => !u.Deletado);
            builder.HasKey(u => u.IdReceita);
            builder.Property(u => u.DataCriacao);
            builder.HasOne(u => u.Usuario).WithMany(p => p.Receitas).HasForeignKey(u => u.IdUsuario);
            builder.HasOne(d => d.FonteRenda).WithMany(d => d.Receitas).HasForeignKey(d => d.IdFonteRenda);

        }
    }
}
