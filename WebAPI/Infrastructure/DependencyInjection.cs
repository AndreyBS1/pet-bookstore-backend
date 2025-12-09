using Microsoft.EntityFrameworkCore;
using System.Reflection;
using PetBookstore.Domain.SeedWork;

namespace PetBookstore.WebAPI.Infrastructure;

public static class DependencyInjection
{
    public static void AddWebAPIInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services
            .AddDbContext<GlobalDbContext>(opt => opt.UseNpgsql(config.GetConnectionString("PostgreSQLContext")));

        var repositories = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x is { IsClass: true, IsAbstract: false, IsPublic: true });

        foreach (var repository in repositories)
        {
            if (repository.GetConstructor(new[] { typeof(GlobalDbContext) }) is null)
            {
                throw new ApplicationException($"Repository {repository.Name} not registered: can't find valid constructor");
            }

            var repositoryInterface = repository
                .GetInterfaces()
                .FirstOrDefault(x => x
                    .GetInterfaces()
                    .Any(y => y.IsGenericType && y.GetGenericTypeDefinition() == typeof(IRepository<>)));

            if (repositoryInterface != null)
            {
                services.AddScoped(repositoryInterface, repository);
            }
            else
            {
                throw new ApplicationException($"Repository {repository.Name} not registered: Unable to find a valid IRepository<> interface implemented by the class");
            }
        }
    }
}
