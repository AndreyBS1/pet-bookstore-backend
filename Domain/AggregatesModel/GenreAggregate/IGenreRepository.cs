using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Domain.AggregatesModel.GenreAggregate;

public interface IGenreRepository : IRepository<Genre>
{
    public Task<List<Genre>> GetAllAsync();
}
