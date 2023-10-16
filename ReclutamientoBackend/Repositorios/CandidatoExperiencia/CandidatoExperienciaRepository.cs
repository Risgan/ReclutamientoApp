using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Models.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.Candidato;
using ReclutamientoBackend.Repositorios.Repository;
using ReclutamientoBackend.Services.Candidato;
using ReclutamientoBackend.Services.CandidatoExperiencia;

namespace ReclutamientoBackend.Repositorios.CandidatoExperiencia
{
    public class CandidatoExperienciaRepository : ICandidatoExperienciaRepository
    {
        private readonly ICandidatoExperienciaService _candidatoExperienciaService;

        public CandidatoExperienciaRepository(ICandidatoExperienciaService candidatoExperienciaService)
        {
            _candidatoExperienciaService = candidatoExperienciaService;
        }

        public async Task<bool> Create(CandidatoExperienciaModel model)
        {
            return await _candidatoExperienciaService.Add(model);
        }

        public async Task<bool> DeleteById(int id)
        {
            return await _candidatoExperienciaService.Delete(id);

        }

        public async Task<IEnumerable<CandidatoExperienciaModel>> GetAll()
        {
            return await _candidatoExperienciaService.GetAll();

        }

        public async Task<CandidatoExperienciaModel> GetById(int id)
        {
            return await _candidatoExperienciaService.Get(id);

        }

        public async Task<bool> Update(int id, CandidatoExperienciaModel model)
        {
            return await _candidatoExperienciaService.Update(id, model);
        }
    }
}
