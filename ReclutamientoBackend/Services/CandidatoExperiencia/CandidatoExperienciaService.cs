using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.DataAccess;
using ReclutamientoBackend.Models.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.Repository;
using ReclutamientoBackend.Services.Candidato;

namespace ReclutamientoBackend.Services.CandidatoExperiencia
{
    public class CandidatoExperienciaService : GenericRepository<CandidatoExperienciaModel>, ICandidatoExperienciaService
    {
        private readonly DbReclutamientoContext _context;

        public CandidatoExperienciaService(DbReclutamientoContext context) : base(context)
        {
            _context = context;
        }
    }
}
