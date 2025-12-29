using Financas.Dominio.Entidades;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioReceita : IRepositorioBase<Receita>
    {
        Task<IEnumerable<Receita>> ObterTodasReceitasComFontesRendas();
        Task<Receita> ObterReceitaPorId(int id);
        Task<Receita> AtualizarReceita(Receita receita);
    }
}
