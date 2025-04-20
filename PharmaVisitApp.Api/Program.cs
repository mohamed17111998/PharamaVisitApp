using PharmaVisitApp.Api.Entities.Services;
using PharmaVisitApp.Api.Infrastructre;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<PharmaVisitDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.Inject(); // ajouter mes services a l'injection de dependences
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
await app.Services.Seed(); // seed utilisateur admin

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
