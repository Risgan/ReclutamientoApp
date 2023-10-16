using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.DataAccess;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Repositorios.Repository;

namespace ReclutamientoBackend.Services.Candidato
{
    public class CandidatoService : GenericRepository<CandidatoModel>, ICandidatoService
    {
        private readonly DbReclutamientoContext _context;

        public CandidatoService(DbReclutamientoContext context) : base(context)
        {
            _context = context;
        }
    }
}
