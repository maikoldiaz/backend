using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Repositories
{
    public interface IRepository<TEntity> where TEntity : class, TEntity
    {
        void Isert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<TEntity> GetByIdAsync(object id);

        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, params string[] includeProperties);
    }
}