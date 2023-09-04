using Microsoft.EntityFrameworkCore;

namespace Tickets.Data.BaseEntity
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly Appdbcontext _appdbcontext;

        public BaseRepository(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public async Task AddActor(T actor)
        {
            await _appdbcontext.Set<T>().AddAsync(actor);
            await _appdbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetActors()
        {
            var allactors = await _appdbcontext.Set<T>().ToListAsync();
            return allactors;
        }

        public async Task<T> Getbyid(int id)
        {
            var getactorbyid = await _appdbcontext.Set<T>().FirstOrDefaultAsync(n => n.IdActor == id);
            return getactorbyid;
        }

        public async Task RemoveActor(int id)
        {
            var getactorbyid = await _appdbcontext.Set<T>().FirstOrDefaultAsync(n => n.IdActor == id);

            var delete = _appdbcontext.Entry<T>(getactorbyid);
            delete.State = EntityState.Deleted;
            await _appdbcontext.SaveChangesAsync();
        }

        public async Task UpdateActor(int id, T updatedactor)
        {
           var update= _appdbcontext.Entry<T>(updatedactor);
            update.State = EntityState.Modified;
            await _appdbcontext.SaveChangesAsync();
          
        }
    }
}
