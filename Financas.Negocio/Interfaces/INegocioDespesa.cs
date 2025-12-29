using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioDespesa
    {
        Task<DespesaVO> AdicionarSalvar(DespesaVO despesaVO);
        Task<IEnumerable<DespesaVO>> ObterDespesasComTiposPagamentos();
        Task<IEnumerable<DespesaVO>> ObterTodos();
        Task<DespesaVO> ObterDespesaPorId(int Id);
        Task<DespesaVO> AtualizarDespesa(DespesaVO despesaVO);
        Task StatusDeletado(int Id);
        Task<IEnumerable<TipoPagamentoVO>> ObterTiposPagamentos();

    }
}
