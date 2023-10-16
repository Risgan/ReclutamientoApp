using ReclutamientoBackend.Dto.CandidatoExperiencia;
using ReclutamientoBackend.Models.CandidatoExperiencia;

namespace ReclutamientoBackend.Repositorios.CandidatoExperiencia
{
    public interface ICandidatoExperienciaRepository
    {
        Task<bool> Create(CandidatoExperienciaCreateDto model);
        Task<IEnumerable<CandidatoExperienciaResponseDto>> GetAll();
        Task<CandidatoExperienciaResponseDto> GetById(int id);
        Task<bool> Update(int id, CandidatoExperienciaModel model);
        Task<bool> DeleteById(int id);
    }
}
