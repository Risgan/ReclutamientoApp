using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ReclutamientoBackend.Models.CandidatoExperiencia
{
    public class CandidatoExperienciaModel
    {
        [Key]
        [DisplayName("IdCandidateExperience")]
        public int IdCandidateExperience { get; set; }

        [DisplayName("IdCandidate")]
        public int IdCandidate { get; set; }

        [DisplayName("Company")]
        public string Company { get; set; }

        [DisplayName("Job")]
        public string Job { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Salary")]
        public float Salary { get; set; }

        [DisplayName("BeginDate")]
        public DateTime BeginDate { get; set; }

        [DisplayName("EndDate")]
        public DateTime? EndDate { get; set; }

        [DisplayName("InsertDate")]
        public DateTime InsertDate { get; set; }

        [DisplayName("ModifyDate")]
        public DateTime? ModifyDate { get; set; }

    }
}
