
using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Repositorios.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.IRepository;
using ReclutamientoBackend.Repositorios.Repository;
using ReclutamientoBackend.Services.Candidato;
using ReclutamientoBackend.Services.CandidatoExperiencia;

namespace ReclutamientoBackend.Repositorios.Candidato
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoRepository(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        public async Task<bool> Create(CandidatoModel model)
        {
            return await _candidatoService.Add(model);
        }

        public async Task<bool> DeleteById(int id)
        {
            return await _candidatoService.Delete(id);

        }

        public async Task<IEnumerable<CandidatoModel>> GetAll()
        {
            return await _candidatoService.GetAll();

        }

        public async Task<CandidatoModel> GetById(int id)
        {
            return await _candidatoService.Get(id);

        }

        public async Task<bool> Update(int id, CandidatoModel model)
        {
            return await _candidatoService.Update(id, model);
        }
    }
}

