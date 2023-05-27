using FluxoCaixa.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FluxoCaixa.Infrastructure.Data.Repositories.Base
{
    public class BaseRepository
    {
        public class RepositoryBase<T> 
            : IRepository<T> where T : class
        {
            protected readonly CashInContext Context;
            protected readonly DbSet<T> DbSet;

            public RepositoryBase(CashInContext context)
            {
                if (Context == null)
                {
                    Context = context;
                    DbSet = Context.Set<T>();
                }
            }

            public virtual void Add(T entity)
            {
                DbSet.Add(entity);
            }

            public virtual void Update(T entity)
            {
                DbSet.Update(entity).State = EntityState.Modified;
            }

            public virtual void UpdateRange(ICollection<T> entity)
            {
                DbSet.UpdateRange(entity);
            }

            public virtual void Delete(T entity)
            {
                DbSet.Remove(entity).State = EntityState.Deleted;
            }

            public async Task<ICollection<T>> GetAll(params Expression<Func<T, object>>[] includes)
            {
                var model = DbSet.AsQueryable();
                if (includes != null)
                {
                    model = includes.Aggregate(model, (current, includeProperty) => current.Include(includeProperty));
                }
                return await model.ToListAsync();
            }

            public async Task<T> GetById(Guid id, params Expression<Func<T, object>>[] includes)
            {
                var model = DbSet.AsQueryable();
                if (includes != null)
                {
                    model = includes.Aggregate(model, (current, includeProperty) => current.Include(includeProperty));
                }
                return await DbSet.FindAsync(id);
            }

            public int SaveChanges()
            {
                return Context.SaveChanges();
            }

            public void Dispose()
            {
                Context.Dispose();
            }
        }
    }
}
