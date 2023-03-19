using Microsoft.EntityFrameworkCore;
using MOVIES.DATA.Base;
using MOVIES.Models;

namespace MOVIES.DATA.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        
        public ProducersService(AppDbContext context) :base(context) { }
       

    }
}
