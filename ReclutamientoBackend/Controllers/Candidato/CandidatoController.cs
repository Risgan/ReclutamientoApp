using Microsoft.AspNetCore.Mvc;
using ReclutamientoBackend.Dto.Candidato;
using ReclutamientoBackend.Models.Candidato;
using ReclutamientoBackend.Repositorios.Candidato;

namespace ReclutamientoBackend.Controllers.Candidato
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatoController : Controller
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoController(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCanditados()
        {
            try
            {
                return Ok(await _candidatoRepository.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message});

            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCandidato(int id)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(await _candidatoRepository.GetById(id));

                }
                else
                {
                    return Ok(new CandidatoResponseDto());
                }
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

        [HttpPost]
        public async Task<ActionResult> PostCandidato(CandidatoCreateDto candidatoModel)
        {
            try
            {
                return Ok(await _candidatoRepository.Create(candidatoModel));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutCandidato(int id, CandidatoModel candidatoModel)
        {
            try
            {
                return Ok(await _candidatoRepository.Update(id, candidatoModel));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a duplicidad del correo." + ex.Message });

            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCandidato(int id)
        {
            try
            {
                return Ok(await _candidatoRepository.DeleteById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

    }
}
