using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Models.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.Repository;
using ReclutamientoBackend.Services.Candidato;

namespace ReclutamientoBackend.Services.CandidatoExperiencia
{
    public class CandidatoExperienciaService : GenericRepository<CandidatoExperienciaModel>, ICandidatoExperienciaService
    {
        public CandidatoExperienciaService(DbContext context) : base(context)
        {
        }
    }
}
