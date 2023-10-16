using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ReclutamientoBackend.Models.CandidatoExperiencia
{
    public class CandidatoExperienciaModel
    {
        [Key]
        [DisplayName("IdCandidate")]
        public int IdCandidate { get; set; }

        //[DisplayName("Name")]
        //public string Name { get; set; }

        //[DisplayName("Surname")]
        //public string Surname { get; set; }

        //[DisplayName("Birthdate")]
        //public DateTime Birthdate { get; set; }

        //[DisplayName("Email")]
        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        //[DisplayName("InsertDate")]
        //public DateTime InsertDate { get; set; }

        //[DisplayName("ModifyDate")]
        //public DateTime ModifyDate { get; set; }
    }
}
