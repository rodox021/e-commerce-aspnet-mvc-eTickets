using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Services
{
    public class MoviesServices
    {


        private readonly AppDbContext _context;

        public MoviesServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> FindAllAsync()
        {
            return await _context.Movies.OrderBy(a => a.Name).ToListAsync();
        }

    }
}
