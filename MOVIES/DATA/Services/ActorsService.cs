﻿using Microsoft.EntityFrameworkCore;
using MOVIES.DATA.Base;
using MOVIES.Models;

namespace MOVIES.DATA.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context) :base(context) { }
       

    }
}
