﻿using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync(); 

        Task<Actor> GetByIdAsync(int id);

        Task InsertAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor newActor);
        
        Task DeleteAsync(int id);

    }
}
