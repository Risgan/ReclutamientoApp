using ReclutamientoBackend.Dto.CandidatoExperiencia;
using ReclutamientoBackend.Models.CandidatoExperiencia;

namespace ReclutamientoBackend.Mappers.CandidatoExperiencia
{
    public class CandidatoExperienciaMapper
    {
        public static CandidatoExperienciaModel MapCreate(CandidatoExperienciaCreateDto dto)
        {
            return new CandidatoExperienciaModel()
            {
                IdCandidateExperience = 0,
                IdCandidate = dto.IdCandidate,
                Company = dto.Company,
                Job = dto.Job,
                Description = dto.Description,
                Salary = dto.Salary,
                BeginDate = dto.BeginDate,
                EndDate = dto.EndDate,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoExperienciaCreateDto MapCreate(CandidatoExperienciaModel dto)
        {
            return new CandidatoExperienciaCreateDto()
            {
                IdCandidate = dto.IdCandidate,
                Company = dto.Company,
                Job = dto.Job,
                Description = dto.Description,
                Salary = dto.Salary,
                BeginDate = dto.BeginDate,
                EndDate = dto.EndDate,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoExperienciaResponseDto MapResponse(CandidatoExperienciaModel dto)
        {
            return new CandidatoExperienciaResponseDto()
            {
                IdCandidateExperience = dto.IdCandidateExperience,
                IdCandidate = dto.IdCandidate,
                Company = dto.Company,
                Job = dto.Job,
                Description = dto.Description,
                Salary = dto.Salary,
                BeginDate = dto.BeginDate,
                EndDate = dto.EndDate,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoExperienciaModel MapResponse(CandidatoExperienciaResponseDto dto)
        {
            return new CandidatoExperienciaModel()
            {
                IdCandidateExperience = dto.IdCandidateExperience,
                IdCandidate = dto.IdCandidate,
                Company = dto.Company,
                Job = dto.Job,
                Description = dto.Description,
                Salary = dto.Salary,
                BeginDate = dto.BeginDate,
                EndDate = dto.EndDate,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        internal static IEnumerable<CandidatoExperienciaResponseDto> MapResponse(IEnumerable<CandidatoExperienciaModel> enumerable)
        {
            IEnumerable<CandidatoExperienciaResponseDto> response = enumerable.Select(MapResponse);
            return response;
        }
    }
}
