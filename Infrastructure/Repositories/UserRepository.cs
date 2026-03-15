using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Infrastructure.Contexts;

namespace PetBookstore.Infrastructure.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
  public UserRepository(GlobalDbContext context) : base(context)
  {
    EntitySet = context.Users;
  }

  public Task<List<User>> GetRangeAsync(int offset, int limit)
  {
    return EntitySet.Skip(offset).Take(limit).ToListAsync();
  }
}
