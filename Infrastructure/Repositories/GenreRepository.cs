using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Infrastructure.Contexts;

namespace PetBookstore.Infrastructure.Repositories;

public class GenreRepository : Repository<Genre>, IGenreRepository
{
  public GenreRepository(GlobalDbContext context) : base(context)
  {
    EntitySet = context.Genres;
  }

  public Task<List<Genre>> GetAllAsync()
  {
    return EntitySet.ToListAsync();
  }
}
