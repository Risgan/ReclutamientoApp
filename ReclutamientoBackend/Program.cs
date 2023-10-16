using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.DataAccess;
using ReclutamientoBackend.Repositorios.Candidato;
using ReclutamientoBackend.Repositorios.CandidatoExperiencia;
using ReclutamientoBackend.Services.Candidato;
using ReclutamientoBackend.Services.CandidatoExperiencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbReclutamientoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection"));
});

builder.Services.AddScoped<ICandidatoService, CandidatoService>();
//builder.Services.AddScoped<ICandidatoExperienciaService, CandidatoExperienciaService>();
builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>();
//builder.Services.AddScoped<ICandidatoExperienciaRepository, CandidatoExperienciaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
