using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Infrastructure.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, IAggregateRoot
{
    private readonly GlobalDbContext _context;
    protected readonly DbSet<TEntity> EntitySet;

    public IUnitOfWork UnitOfWork
    {
        get => _context;
    }

    public Repository(GlobalDbContext context)
    {
        _context = context;
        EntitySet = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        EntitySet.Add(entity);
    }

    public Task<TEntity?> GetByIdAsync(int ID)
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
