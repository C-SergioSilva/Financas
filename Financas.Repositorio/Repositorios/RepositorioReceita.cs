using Financas.Dominio.Entidades;
using Financas.Dominio.Interfaces;
using Financas.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repositorio.Repositorios
{
    public class RepositorioReceita : RepositorioBase<Receita>, IRepositorioReceita
    {
        public RepositorioReceita(DbContexto contexto) : base(contexto){}

        public async Task<Receita> AtualizarReceita(Receita receita)
        {
            try
            {
                var atualizaEntidade = await contexto.Receitas.SingleOrDefaultAsync(e => e.IdReceita.Equals(receita.IdReceita));

                if (atualizaEntidade == null)
                {
                    return null;
                }
                contexto.Entry(atualizaEntidade).CurrentValues.SetValues(receita);
                await contexto.SaveChangesAsync();
                return receita;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<Receita> ObterReceitaPorId(int id)
        {
            try
            {
                return await contexto.Receitas.Include(r=>r.FonteRenda).SingleOrDefaultAsync(e => e.IdReceita.Equals(id));
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<IEnumerable<Receita>> ObterTodasReceitasComFontesRendas()
        {
            try
            {
                var listaReceita = await contexto.Receitas
                .Include(r =>r.FonteRenda)
                .ToListAsync();
                return listaReceita;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }
    }
}
