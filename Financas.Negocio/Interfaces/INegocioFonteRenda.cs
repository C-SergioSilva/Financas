using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioFonteRenda
    {
        Task<FonteRendaVO> AdicionarSalvar(FonteRendaVO fonteRendaVO);
        Task<IEnumerable<FonteRendaVO>> ObterTodos();
        Task<FonteRendaVO> ObterFonteRendaPorId(int id);
        Task<FonteRendaVO> AtualizarFonteRenda(FonteRendaVO fonteRendaVO);
        Task StatusDeletado(int id);

    }
}
