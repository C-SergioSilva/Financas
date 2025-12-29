using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        Task<IEnumerable<Despesa>> ObterTodasDespesasComTiposPagamentos();
        Task<IEnumerable<TipoPagamento>> ObterTiposPagamentos();
        Task<Despesa> ObterDespesaPorId(int id);
        Task<Despesa> AtualizarDespesa(Despesa despesa);
    }
}
