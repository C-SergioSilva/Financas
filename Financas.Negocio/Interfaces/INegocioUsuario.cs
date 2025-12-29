using Financas.Negocio.EntidadeVO;

namespace Financas.Negocio.Interfaces
{
    public interface INegocioUsuario
    {
        Task<UsuarioVO> AdicionarSalvar(UsuarioVO usuarioVO);

        Task<IEnumerable<UsuarioVO>> ObterTodos();

        Task<UsuarioVO> Atualizar(UsuarioVO usuarioVO);

        Task StatusDeletado(int Id);

        Task<IEnumerable<UsuarioVO>> ObterUsuariosComPerfil();

        Task<UsuarioVO> ObterUsuarioPorID(int Id);

        Task<UsuarioVO> ObterUsuarioPorEmailSenha(string email, string senha);

    }
}
