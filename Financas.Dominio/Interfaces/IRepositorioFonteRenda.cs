using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioFonteRenda : IRepositorioBase<FonteRenda>
    {
        Task<FonteRenda> ObterFonteRendaPorId(int id);
        Task<FonteRenda> AtualizarFonteRenda(FonteRenda fonteRenda);
    }
}
