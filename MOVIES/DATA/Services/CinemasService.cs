using Microsoft.EntityFrameworkCore;
using MOVIES.DATA.Base;
using MOVIES.Models;

namespace MOVIES.DATA.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context) :base(context) { }
       

    }
}
