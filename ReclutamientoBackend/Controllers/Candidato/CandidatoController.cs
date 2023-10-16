using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReclutamientoBackend.Controllers.Candidato
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatoController : Controller
    {
        public CandidatoController()
        {
            
        }

        [HttpGet("GetAll")]
        public ActionResult GetAllCanditados()
        {
            return Ok(1);
        }

        [HttpGet("{id}")]
        public ActionResult GetCandidato(int id)
        {
            return Ok(1);
        }

        [HttpPost]
        public ActionResult PostCandidato()
        {
            return Ok(1);
        }

        [HttpPut]
        public ActionResult PutCandidato()
        {
            return Ok(1);
        }

        [HttpDelete]
        public ActionResult DeleteCandidato()
        {
            return Ok(1);
        }

    }
}
