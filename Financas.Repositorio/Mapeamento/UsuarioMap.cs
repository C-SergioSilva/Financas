using Financas.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financas_repositorio.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

				builder.ToTable("Usuario");
				builder.HasQueryFilter(u => !u.Deletado);
				builder.HasKey(u => u.IdUsuario);
				builder.Property(u => u.DataCriacao);
				builder.HasOne(u => u.Perfil).WithMany(p => p.Usuarios).HasForeignKey(u => u.IdPerfil);
                builder.HasMany(u => u.Despesas).WithOne(p => p.Usuario).HasForeignKey(u => u.IdUsuario);
                builder.HasMany(u => u.Receitas).WithOne(p => p.Usuario).HasForeignKey(u => u.IdUsuario);

        }
    }
}
