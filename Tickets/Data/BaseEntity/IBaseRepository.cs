using Tickets.Models;

namespace Tickets.Data.BaseEntity
{
    public interface IBaseRepository<T>where T : class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Getbyid(int id);
        Task Add(T actor);
        Task Remove(int id);
        Task Update(int id, T update);
    }
}
