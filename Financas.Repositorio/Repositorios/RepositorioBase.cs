using Financas.Dominio.Identidade;
using Financas.Dominio.Interfaces;
using Financas.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repositorio.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        protected readonly DbContexto contexto;
        protected DbSet<T> dbSet;
        public RepositorioBase(DbContexto contexto)
        {
            this.contexto = contexto;
            this.dbSet = contexto.Set<T>();
        }
        public async Task Commit()
        {
            try
            {
                await contexto.SaveChangesAsync();
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }
        public IQueryable<T> Queryable()
        {
            return dbSet as IQueryable<T>;
        }
        public void Adicionar(T entidade)
        {
            try
            {
                dbSet.Add(entidade);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }

        public async Task<T> AdicionarSalvar(T entidade)
        {
            try
            {

                dbSet.Add(entidade);
                await contexto.SaveChangesAsync();
                return entidade;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }
        public async Task StatusDeletado(T entidade)
        {
            try
            {
                await contexto.SaveChangesAsync();
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message, exception);

            }
        }

    }
}
