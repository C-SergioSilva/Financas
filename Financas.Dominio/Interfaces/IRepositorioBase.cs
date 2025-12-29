using Financas.Dominio.Identidade;

namespace Financas.Dominio.Interfaces
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        IQueryable<T> Queryable();
        Task Commit();
        void Adicionar(T entidade);
        Task<T> AdicionarSalvar(T entidade);
        Task<IEnumerable<T>> ObterTodos();
        Task StatusDeletado(T entidade);


    }
}
