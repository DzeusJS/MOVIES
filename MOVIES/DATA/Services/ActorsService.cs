using Microsoft.EntityFrameworkCore;
using MOVIES.DATA.Base;
using MOVIES.Models;

namespace MOVIES.DATA.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) :base(context) { }
       

    }
}
