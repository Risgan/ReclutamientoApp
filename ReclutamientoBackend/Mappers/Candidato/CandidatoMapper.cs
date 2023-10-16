using ReclutamientoBackend.Dto.Candidato;
using ReclutamientoBackend.Models.Candidato;

namespace ReclutamientoBackend.Mappers.Candidato
{
    public class CandidatoMapper
    {
        public static CandidatoModel MapCreate(CandidatoCreateDto dto)
        {
            return new CandidatoModel()
            {
                IdCandidate = 0,
                Name = dto.Name,
                Surname = dto.Surname,
                Birthdate = dto.Birthdate,
                Email = dto.Email,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoCreateDto MapCreate(CandidatoModel dto)
        {
            return new CandidatoCreateDto()
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Birthdate = dto.Birthdate,
                Email = dto.Email,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoResponseDto MapResponse(CandidatoModel dto)
        {
            return new CandidatoResponseDto()
            {
                IdCandidate = dto.IdCandidate,
                Name = dto.Name,
                Surname = dto.Surname,
                Birthdate = dto.Birthdate,
                Email = dto.Email,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        public static CandidatoModel MapResponse(CandidatoResponseDto dto)
        {
            return new CandidatoModel()
            {
                IdCandidate = dto.IdCandidate,
                Name = dto.Name,
                Surname = dto.Surname,
                Birthdate = dto.Birthdate,
                Email = dto.Email,
                InsertDate = dto.InsertDate,
                ModifyDate = dto.ModifyDate
            };
        }

        internal static IEnumerable<CandidatoResponseDto> MapResponse(IEnumerable<CandidatoModel> enumerable)
        {
            IEnumerable<CandidatoResponseDto> response = enumerable.Select(MapResponse);
            return response;
        }
    }
}
