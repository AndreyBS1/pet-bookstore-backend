using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.SeedWork;
using PetBookstore.Infrastructure.Contexts;

namespace PetBookstore.Infrastructure.Repositories;

public abstract class Repository<TEntity>(GlobalDbContext context) : IRepository<TEntity> where TEntity : Entity, IAggregateRoot
{
  protected DbSet<TEntity> EntitySet = context.Set<TEntity>();

  public void Add(TEntity entity)
  {
    EntitySet.Add(entity);
  }

  public Task<TEntity?> GetByIDAsync(int ID)
  {
    return EntitySet.FirstOrDefaultAsync(e => e.ID == ID);
  }

  public void Update(TEntity entity)
  {
    EntitySet.Update(entity);
  }

  public void Remove(TEntity entity)
  {
    EntitySet.Remove(entity);
  }
}
