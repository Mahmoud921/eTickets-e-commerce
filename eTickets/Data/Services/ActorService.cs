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
        public void Add(Actor actor)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetById(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return actor;
        }

        public Actor Update(int id, Actor newActor)
        {
            return null;
        }
    }
}
