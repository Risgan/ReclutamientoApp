using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReclutamientoBackend.Models.CandidatoExperiencia
{
    [Table("CandidatesExperiences")]
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
        public Decimal Salary { get; set; }

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
