using Map.Core.Interfaces;
using Map.Data.DBContext;
using Map.Data.Repositories.Interfaces;

namespace Map.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, ISoftDeleteable
    {
        protected ArticleDBContext DbContext { get; }
        protected RepositoryBase(ArticleDBContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
