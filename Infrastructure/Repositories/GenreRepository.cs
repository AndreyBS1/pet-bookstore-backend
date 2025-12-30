using Microsoft.EntityFrameworkCore;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Infrastructure.Repositories;

public class GenreRepository(GlobalDbContext context) : Repository<Genre>(context), IGenreRepository
{
    public Task<List<Genre>> GetAllAsync()
    {
        return EntitySet.ToListAsync();
    }
}
