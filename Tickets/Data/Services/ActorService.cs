using Microsoft.EntityFrameworkCore;
using Tickets.Data.BaseEntity;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class ActorService :BaseRepository<Actor>, IActor
    {

        public ActorService(Appdbcontext appdbcontext) : base(appdbcontext) { }
       
     
    }
}
