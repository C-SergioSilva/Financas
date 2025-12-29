using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioPerfil : IRepositorioBase<Perfil>
    {
        Task<Perfil> ObterPerfilPorId(int id);
        Task<Perfil> AtualizarPerfil(Perfil perfil);
    }
}
