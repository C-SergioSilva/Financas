using Financas.Dominio.Entidades;
using Financas.Dominio.Interfaces;
using Financas.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repositorio.Repositorios
{
    public class RepositorioDespesa : RepositorioBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesa(DbContexto contexto) : base(contexto){ }

        public async Task<Despesa> AtualizarDespesa(Despesa despesa)
        {
            try
            {
                var atualizaEntidade = await contexto.Despesas.SingleOrDefaultAsync(e => e.IdDespesa.Equals(despesa.IdDespesa));

                if (atualizaEntidade == null)
                {
                    return null;
                }
                contexto.Entry(atualizaEntidade).CurrentValues.SetValues(despesa);
                await contexto.SaveChangesAsync();
                return despesa;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<IEnumerable<Despesa>> ObterTodasDespesasComTiposPagamentos()
        {
            try
            {
                var listaDespesa = await contexto.Despesas
                .Include(d => d.TipoPagamento)
                .ToListAsync();
                return listaDespesa;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<Despesa> ObterDespesaPorId(int id)
        {
            try
            {
                return await contexto.Despesas.Include(d=>d.TipoPagamento).SingleOrDefaultAsync(e => e.IdDespesa.Equals(id));
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<IEnumerable<TipoPagamento>> ObterTiposPagamentos()
        {
            try
            {
                return await contexto.TipoPagamentos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
