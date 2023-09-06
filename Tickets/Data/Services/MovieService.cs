using Tickets.Data.BaseEntity;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class MovieService:BaseRepository<Movie>,IMovies
    {
        public MovieService(Appdbcontext appdbcontext) : base(appdbcontext) { }
    }
}
