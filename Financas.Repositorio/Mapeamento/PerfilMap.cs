using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {

                builder.ToTable("Perfil");
                builder.HasKey(u => u.IdPerfil);
                builder.HasQueryFilter(p => !p.Deletado);
                builder.Property(p => p.Descricao).IsRequired().HasMaxLength(50);
                builder.HasMany(p => p.Usuarios).WithOne(u => u.Perfil).HasForeignKey(u => u.IdPerfil);

        }
    }
}
