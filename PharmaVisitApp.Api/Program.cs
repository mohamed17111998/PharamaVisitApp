using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PharmaVisitApp.Api.Domain.Helpers;
using PharmaVisitApp.Api.Infrastructre;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Inject(builder.Configuration); // ajouter mes services a l'injection de dependences
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PharmaAppClient", Version = "v1" });
});

var app = builder.Build();

// Creation de la base de donnees automtique et l'appliction des migration ef core
using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<PharmaVisitDbContext>();
    dbContext.Database.Migrate();
}

await app.Services.Seed(); // seed utilisateur admin et profiles
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
