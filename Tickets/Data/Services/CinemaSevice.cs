using Tickets.Data.BaseEntity;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class CinemaSevice : BaseRepository<Cinema>, ICinema
    {
        public CinemaSevice(Appdbcontext appdbcontext) : base(appdbcontext) { }

    }
}
