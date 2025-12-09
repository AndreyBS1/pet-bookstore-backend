using Microsoft.EntityFrameworkCore;
// using PetBookstore.Infrastructure;
using PetBookstore.WebAPI.Infrastructure;
using PetBookstore.Application;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// builder.Services.AddInfrastructure(config);
builder.Services.AddWebAPIInfrastructure(config);
builder.Services.AddApplication(config);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// var scope = app.Services.CreateScope();

// var globalDbContext = scope.ServiceProvider.GetRequiredService<GlobalDbContext>();
// // await GlobalDbContext.MigrateAsync(globalDbContext);
// await globalDbContext.Database.MigrateAsync();
//
using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    await scope.ServiceProvider.GetRequiredService<GlobalDbContext>().Database.MigrateAsync();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
