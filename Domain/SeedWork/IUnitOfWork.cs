namespace PetBookstore.Experiment.Domain.SeedWork;

public interface IUnitOfWork : IDisposable
{
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
