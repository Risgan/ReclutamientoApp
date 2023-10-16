
using Microsoft.EntityFrameworkCore;
using ReclutamientoBackend.Dto.Candidato;
using ReclutamientoBackend.Mappers.Candidato;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Repositorios.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.IRepository;
using ReclutamientoBackend.Services.Candidato;

namespace ReclutamientoBackend.Repositorios.Candidato
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoRepository(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        public async Task<bool> Create(CandidatoCreateDto model)
        {
            return await _candidatoService.Add(CandidatoMapper.MapCreate(model));
        }

        public async Task<bool> DeleteById(int id)
        {
            return await _candidatoService.Delete(id);
        }

        public async Task<IEnumerable<CandidatoResponseDto>> GetAll()
        {
            return CandidatoMapper.MapResponse(await _candidatoService.GetAll());
        }

        public async Task<CandidatoResponseDto> GetById(int id)
        {
            return CandidatoMapper.MapResponse(await _candidatoService.Get(id));
        }

        public async Task<bool> Update(int id, CandidatoModel model)
        {
            return await _candidatoService.Update(id, model);
        }
    }
}

