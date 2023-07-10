using Tickets.Models;

namespace Tickets.Data.Services
{
    public interface IActor
    {
       Task< IEnumerable<Actor>> GetActors();
        Actor GetActor(int id);
        void AddActor(Actor actor);
        void RemoveActor(int id);
        void UpdateActor(int id,Actor updatedactor);
    }
}
