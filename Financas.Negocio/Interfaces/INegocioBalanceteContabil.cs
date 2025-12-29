using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioBalanceteContabil
    {
        Task<BalanceteContabilVO> AdicionarSalvar(BalanceteContabilVO balanceteVO);
        Task<IEnumerable<BalanceteContabilVO>> ObterTodos();
        Task<BalanceteContabilVO> ObterBalanceteContabilPorId(int id);
        Task<BalanceteContabilVO> AtualizarBalanceteContabil(BalanceteContabilVO balanceteVO);
        Task StatusDeletado(int id);
        Task<IEnumerable<BalanceteContabilVO>> ObterBalanceteContabilPorPeriodo(string pPeriodicidade);
        Task<ResultadoCalculoBalanceteVO> ResultadoBalanceteContabil(string pInicial, string pFinal, string pPeriodicidade);

    }
}
