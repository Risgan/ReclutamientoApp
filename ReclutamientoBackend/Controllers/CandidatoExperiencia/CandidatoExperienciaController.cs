using Microsoft.AspNetCore.Mvc;
using ReclutamientoBackend.Dto.CandidatoExperiencia;
using ReclutamientoBackend.Models.CandidatoExperiencia;
using ReclutamientoBackend.Repositorios.CandidatoExperiencia;

namespace ReclutamientoBackend.Controllers.ExperienciaExperiencia
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienciaExperienciaController : Controller
    {
        private readonly ICandidatoExperienciaRepository _candidatoExperienciaRepository;

        public ExperienciaExperienciaController(ICandidatoExperienciaRepository candidatoExperienciaRepository)
        {
            _candidatoExperienciaRepository = candidatoExperienciaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCanditados()
        {
            try
            {
                return Ok(await _candidatoExperienciaRepository.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCandidato(int id)
        {
            try
            {
                return Ok(await _candidatoExperienciaRepository.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

        [HttpPost]
        public async Task<ActionResult> PostCandidato(CandidatoExperienciaCreateDto candidatoModel)
        {
            try
            {
                return Ok(await _candidatoExperienciaRepository.Create(candidatoModel));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutCandidato(int id, CandidatoExperienciaModel candidatoModel)
        {
            try
            {
                return Ok(await _candidatoExperienciaRepository.Update(id, candidatoModel));
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
                return Ok(await _candidatoExperienciaRepository.DeleteById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
        }
    }
}
