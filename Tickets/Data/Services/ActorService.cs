using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class ActorService : IActor
    {
        private readonly Appdbcontext _appdbcontext;

        public ActorService(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public void AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor GetActor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>>  GetActors()
        {
            var allactors =await _appdbcontext.actors.ToListAsync();
            return allactors;
        }

        public void RemoveActor(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateActor(int id, Actor updatedactor)
        {
            throw new NotImplementedException();
        }
    }
}
