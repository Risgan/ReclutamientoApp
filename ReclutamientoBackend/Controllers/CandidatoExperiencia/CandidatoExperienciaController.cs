using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReclutamientoBackend.Controllers.ExperienciaExperiencia
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienciaExperienciaController : Controller
    {
        public ExperienciaExperienciaController()
        {
                
        }

        [HttpGet("GetAll")]
        public ActionResult GetAllExperiencia()
        {
            return Ok(1);
        }

        [HttpGet("{id}")]
        public ActionResult GetExperiencia(int id)
        {
            return Ok(1);
        }

        [HttpPost]
        public ActionResult PostExperiencia()
        {
            return Ok(1);
        }

        [HttpPut]
        public ActionResult PutExperiencia()
        {
            return Ok(1);
        }

        [HttpDelete]
        public ActionResult DeleteExperiencia()
        {
            return Ok(1);
        }
    }
}
