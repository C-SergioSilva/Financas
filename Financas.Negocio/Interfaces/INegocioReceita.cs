using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioReceita
    {
        Task<ReceitaVO> AdicionarSalvar(ReceitaVO receitaVO);
        Task<IEnumerable<ReceitaVO>> ObterReceitasComFontesRendas();
        Task<IEnumerable<ReceitaVO>> ObterTodos();
        Task<ReceitaVO> ObterReceitaPorId(int Id);
        Task<ReceitaVO> AtualizarReceita(ReceitaVO receitaVO);
        Task StatusDeletado(int Id);

    }
}
