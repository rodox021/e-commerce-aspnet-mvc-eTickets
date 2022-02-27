using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Services
{
    public class ProducersServices
    {
        private readonly AppDbContext _context;

        public ProducersServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producer>> FindAllAsync()
        {
            return await _context.Producers.OrderBy(a => a.FullName).ToListAsync();
        }
    }
}
     