using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Services
{
    public class ActorsServices
    {
        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Actor>> FindAllAsync()
        {
            return await _context.Actors.OrderBy(a => a.FullName).ToListAsync();
        }
    }
}
