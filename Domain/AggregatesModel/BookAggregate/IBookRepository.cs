using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Domain.AggregatesModel.BookAggregate;

public interface IBookRepository : IRepository<Book>
{
  public Task<List<Book>> GetRangeAsync(int offset, int limit);
}
