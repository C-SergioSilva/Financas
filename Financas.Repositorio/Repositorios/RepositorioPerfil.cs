using Financas.Dominio.Entidades;
using Financas.Dominio.Interfaces;
using Financas.Repositorio.Contexto;
using Financas.Repositorio.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repositorio.Repositorios
{
    public class RepositorioPerfil : RepositorioBase<Perfil>, IRepositorioPerfil
    {
        public RepositorioPerfil(DbContexto contexto): base(contexto) { }

        public async Task<Perfil> AtualizarPerfil(Perfil perfil)
        {
            try
            {
                var atualizaEntidade = await contexto.Perfis.SingleOrDefaultAsync(e => e.IdPerfil.Equals(perfil.IdPerfil));

                if (atualizaEntidade == null)
                {
                    return null;
                }
                contexto.Entry(atualizaEntidade).CurrentValues.SetValues(perfil);
                await contexto.SaveChangesAsync();
                return perfil;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<Perfil> ObterPerfilPorId(int id)
        {
            try
            {
                return await contexto.Perfis.SingleOrDefaultAsync(e => e.IdPerfil.Equals(id));
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }
    }
}
