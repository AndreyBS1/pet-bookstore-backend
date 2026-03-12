using Microsoft.EntityFrameworkCore;
using PetBookstore.Infrastructure.Contexts;
using PetBookstore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<GlobalDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLContext")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
var serviceScope = serviceScopeFactory.CreateScope();
var dbContext = serviceScope.ServiceProvider.GetRequiredService<GlobalDbContext>();
await dbContext.Database.MigrateAsync();
serviceScope.Dispose();

if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
}

// app.UseHttpsRedirection();

app.MapControllers();

app.Run();
