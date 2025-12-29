using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioUsuario : IRepositorioBase<Usuario>
    {
        Task<IEnumerable<Usuario>> ObterUsuariosComPerfil();
        Task<Usuario> ObterUsuarioPorID(int id);

        Task<Usuario> Atualizar(Usuario usuario);

        Task<Usuario> ObterUsuarioPorEmailSenha(string email, string senha);

    }
}
