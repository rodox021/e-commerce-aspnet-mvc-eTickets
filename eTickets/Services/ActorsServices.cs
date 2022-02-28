using eTickets.Data;
using eTickets.Models;
using eTickets.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Services
{
    public class ActorsServices :IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }
        //
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }
        //------------------------DELETE---------------------------------------------
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        //------------------------FIND ALL--------------------------------------------
        public async Task<List<Actor>> FindAllAsync()
        {
            return await _context.Actors.OrderBy(a => a.FullName).ToListAsync();
        }
        //------------------------GetAll-----------------------------------------------
        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.OrderBy(a => a.FullName).ToListAsync();
            return result;
        }
        //------------------------GET BY ID--------------------------------------------
        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }
        //------------------------UPDATE------------------------------------------------
        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
