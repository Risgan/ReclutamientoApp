using ReclutamientoBackend.Dto.CandidatoExperiencia;
using ReclutamientoBackend.Mappers.CandidatoExperiencia;
using ReclutamientoBackend.Models.CandidatoExperiencia;
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

        public async Task<bool> Create(CandidatoExperienciaCreateDto model)
        {
            return await _candidatoExperienciaService.Add(CandidatoExperienciaMapper.MapCreate(model));
        }

        public async Task<bool> DeleteById(int id)
        {
            return await _candidatoExperienciaService.Delete(id);

        }

        public async Task<IEnumerable<CandidatoExperienciaResponseDto>> GetAll()
        {
            return CandidatoExperienciaMapper.MapResponse(await _candidatoExperienciaService.GetAll());

        }

        public async Task<CandidatoExperienciaResponseDto> GetById(int id)
        {
            return CandidatoExperienciaMapper.MapResponse(await _candidatoExperienciaService.Get(id));

        }

        public async Task<bool> Update(int id, CandidatoExperienciaModel model)
        {
            return await _candidatoExperienciaService.Update(id, model);
        }
    }
}
