using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        // Insert Actor
        public async Task InsertAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        // Show All Actors
        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        // Capture Id of Actor
        public async Task<Actor> GetByIdAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return actor;
        }
        
        // Edit Detail of Actor
        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
             _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
        // Delete Actor
        public async Task DeleteAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
             _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }
    }
}
