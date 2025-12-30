using PetBookstore.Experiment.Domain.SeedWork;

namespace PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

public interface IGenreRepository : IRepository<Genre>
{
    public Task<List<Genre>> GetAllAsync();
}
