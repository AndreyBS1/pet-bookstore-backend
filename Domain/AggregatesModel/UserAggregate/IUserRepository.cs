using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Domain.AggregatesModel.UserAggregate;

public interface IUserRepository : IRepository<User>
{
  public Task<List<User>> GetRangeAsync(int offset, int limit);
}
