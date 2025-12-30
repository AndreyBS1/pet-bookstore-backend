using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Infrastructure.Repositories;

public class GenreRepository : Repository<Genre>, IGenreRepository
{
    public GenreRepository(GlobalDbContext context) : base(context)
    {
        this.EntitySet = context.Genres;
    }

    public Task<List<Genre>> GetAllAsync()
    {
        return EntitySet.ToListAsync();
    }
}
