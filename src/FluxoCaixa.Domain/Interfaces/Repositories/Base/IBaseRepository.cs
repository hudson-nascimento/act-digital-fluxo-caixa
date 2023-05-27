using System.Linq.Expressions;

namespace FluxoCaixa.Domain.Interfaces.Repositories.Base
{
    internal interface IBaseRepository
    {
        /// <summary>
        /// Contrato de interface generico para repositório.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IRepository<T> : IDisposable where T : class
        {
            void Add(T entity);

            void Update(T entity);

            void Delete(T entity);

            Task DeleteAsync(Guid id);

            Task<T> GetById(Guid id, params Expression<Func<T, object>>[] includes);

            Task<ICollection<T>> GetAll(params Expression<Func<T, object>>[] includes);

            int SaveChanges();

        }
    }
}
