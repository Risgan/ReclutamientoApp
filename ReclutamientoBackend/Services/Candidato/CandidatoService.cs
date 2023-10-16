using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Repositorios.Repository;

namespace ReclutamientoBackend.Services.Candidato
{
    public class CandidatoService : GenericRepository<CandidatoModel>, ICandidatoService
    {
        public CandidatoService(DbContext context) : base(context)
        {
        }
    }
}
