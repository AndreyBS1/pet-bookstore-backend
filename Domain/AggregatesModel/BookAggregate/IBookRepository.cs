using PetBookstore.Experiment.Domain.SeedWork;

namespace PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

public interface IBookRepository : IRepository<Book>
{
    public Task<List<Book>> GetRangeAsync(int offset, int limit);
}
