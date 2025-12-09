using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace PetBookstore.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IConfiguration config)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
    }
}
