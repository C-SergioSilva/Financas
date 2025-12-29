using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioPerfil
    {
        Task<PerfilVO> AdicionarSalvar(PerfilVO perfilVO);
        Task<IEnumerable<PerfilVO>> ObterTodos();
        Task<PerfilVO> AtualizarPerfil(PerfilVO perfilVO);
        Task<PerfilVO> ObterPerfilPorId(int Id);
        Task StatusDeletado(int Id);
    }
}
