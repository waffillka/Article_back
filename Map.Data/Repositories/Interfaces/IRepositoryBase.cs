using Map.Core.Interfaces;

namespace Map.Data.Repositories.Interfaces
{
    public class IRepositoryBase<TEntity>
        where TEntity : class, ISoftDeleteable
    {
    }
}
