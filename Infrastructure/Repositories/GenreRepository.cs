using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Infrastructure.Repositories;

public class GenreRepository(GlobalDbContext context) : Repository<Genre>(context), IGenreRepository
{
    public Task<List<Genre>> GetAllAsync()
    {
        return EntitySet.ToListAsync();
    }
}
