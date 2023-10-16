using ReclutamientoBackend.Models.Candidato;

namespace ReclutamientoBackend.Repositorios.Candidato
{
    public interface ICandidatoRepository
    {
        Task<bool> Create(CandidatoModel model);
        Task<IEnumerable<CandidatoModel>> GetAll();
        Task<CandidatoModel> GetById(int id);
        Task<bool> Update(int id, CandidatoModel model);
        Task<bool> DeleteById(int id);
    }
}
