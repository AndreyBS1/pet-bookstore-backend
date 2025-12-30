namespace PetBookstore.Experiment.Domain.SeedWork;

public interface IRepository<TEntity> where TEntity : Entity, IAggregateRoot
{
    public IUnitOfWork UnitOfWork { get; }

    public void Add(TEntity entity);

    public Task<TEntity?> GetByIDAsync(int entityID);

    public void Update(TEntity entity);

    public void Remove(TEntity entity);
}
