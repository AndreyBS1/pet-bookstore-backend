using Microsoft.EntityFrameworkCore;
using PetBookstore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services
    .AddDbContext<GlobalDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLContext")));

var app = builder.Build();

var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using var scope = serviceScopeFactory.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<GlobalDbContext>();
await dbContext.Database.MigrateAsync();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
