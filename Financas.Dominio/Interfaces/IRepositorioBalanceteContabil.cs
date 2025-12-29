using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioBalanceteContabil : IRepositorioBase<BalanceteContabil>
    {
        Task<IEnumerable<BalanceteContabil>> ObterBalanceteContabilPorPeriodo(string pPeriodicidade);
        Task<BalanceteContabil> ObterBalanceteContabilPorId(int id);
        Task<BalanceteContabil> AtualizarBalanceteContabil(BalanceteContabil pBalancete);
        Task<ResultadoCalculoBalancete> ResultadoBalanceteContabil(string pInicial, string pFinal, string pPeriodicidade);
    }
}
 