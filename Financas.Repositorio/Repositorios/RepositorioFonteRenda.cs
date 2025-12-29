using Financas.Dominio.Entidades;
using Financas.Dominio.Interfaces;
using Financas.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repositorio.Repositorios
{
    public class RepositorioFonteRenda : RepositorioBase<FonteRenda>, IRepositorioFonteRenda
    {
        public RepositorioFonteRenda(DbContexto contexto) : base(contexto) { }

        public async Task<FonteRenda> AtualizarFonteRenda(FonteRenda fonteRenda)
        {
            try
            {
                var atualizaEntidade = await contexto.FonteRendas.SingleOrDefaultAsync(e => e.IdFonteRenda.Equals(fonteRenda.IdFonteRenda));

                if (atualizaEntidade == null)
                {
                    return null;
                }
                contexto.Entry(atualizaEntidade).CurrentValues.SetValues(fonteRenda);
                await contexto.SaveChangesAsync();
                return fonteRenda;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<FonteRenda> ObterFonteRendaPorId(int id)
        {
            try
            {
                return await contexto.FonteRendas.SingleOrDefaultAsync(e => e.IdFonteRenda.Equals(id));

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
