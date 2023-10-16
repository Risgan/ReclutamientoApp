using ReclutamientoBackend.Dto.Candidato;
using ReclutamientoBackend.Models.Candidato;

namespace ReclutamientoBackend.Repositorios.Candidato
{
    public interface ICandidatoRepository
    {
        Task<bool> Create(CandidatoCreateDto model);
        Task<IEnumerable<CandidatoResponseDto>> GetAll();
        Task<CandidatoResponseDto> GetById(int id);
        Task<bool> Update(int id, CandidatoModel model);
        Task<bool> DeleteById(int id);
    }
}
