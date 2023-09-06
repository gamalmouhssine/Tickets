using System.Linq.Expressions;
using Tickets.Models;

namespace Tickets.Data.BaseEntity
{
    public interface IBaseRepository<T>where T : class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties  );
        Task<T> Getbyid(int id);
        Task Add(T actor);
        Task Remove(int id);
        Task Update(int id, T update);
    }
}
