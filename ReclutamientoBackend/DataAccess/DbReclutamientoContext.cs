using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Models.CandidatoExperiencia;

namespace ReclutamientoBackend.DataAccess
{
    public class DbReclutamientoContext : DbContext
    {
        public DbReclutamientoContext(DbContextOptions<DbReclutamientoContext> options) : base(options)
        {
        }

        // Define las propiedades DbSet para tus entidades
        public DbSet<CandidatoModel> CandidatoModel { get; set; }
        public DbSet<CandidatoExperienciaModel> CandidatoExperienciaModel { get; set; }
    }
}
