using ReclutamientoBackend.Models.CandidatoExperiencia;

namespace ReclutamientoBackend.Repositorios.CandidatoExperiencia
{
    public interface ICandidatoExperienciaRepository
    {
        Task<bool> Create(CandidatoExperienciaModel model);
        Task<IEnumerable<CandidatoExperienciaModel>> GetAll();
        Task<CandidatoExperienciaModel> GetById(int id);
        Task<bool> Update(int id, CandidatoExperienciaModel model);
        Task<bool> DeleteById(int id);
    }
}
