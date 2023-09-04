using Tickets.Models;

namespace Tickets.Data.BaseEntity
{
    public interface IBaseRepository<T>where T : class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetActors();
        Task<T> Getbyid(int id);
        Task AddActor(T actor);
        Task RemoveActor(int id);
        Task UpdateActor(int id, T updatedactor);
    }
}
