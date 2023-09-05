using Tickets.Data.BaseEntity;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class ProducerService: BaseRepository<Producer>, IProducer
    {
        public ProducerService(Appdbcontext appdbcontext) : base(appdbcontext) { }

    }
}
