using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Services
{
    public class CinemasServices
    {
        private readonly AppDbContext _context;

        public CinemasServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cinema>> FindAllAsync()
        {
            return await _context.Cinemas.OrderBy(a => a.Name).ToListAsync();
        }
    }
}
