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
        public async Task Add(T actor)
        {
            await _appdbcontext.Set<T>().AddAsync(actor);
            await _appdbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll ()
        {
            var allactors = await _appdbcontext.Set<T>().ToListAsync();
            return allactors;
        }

        public async Task<T> Getbyid(int id)
        {
            var getactorbyid = await _appdbcontext.Set<T>().FirstOrDefaultAsync(n => n.id == id);
            return getactorbyid;
        }

        public async Task Remove(int id)
        {
            var getactorbyid = await _appdbcontext.Set<T>().FirstOrDefaultAsync(n => n.id == id);

            var delete = _appdbcontext.Entry<T>(getactorbyid);
            delete.State = EntityState.Deleted;
            await _appdbcontext.SaveChangesAsync();
        }

        public async Task Update(int id, T update)
        {
           var upgrade= _appdbcontext.Entry<T>(update);
            upgrade.State = EntityState.Modified;
            await _appdbcontext.SaveChangesAsync();
          
        }
    }
}
