using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReclutamientoBackend.Models.Candidato
{
    [Table("Candidates")]
    public class CandidatoModel
    {
        [Key]
        [DisplayName("IdCandidate")]
        public int IdCandidate { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Surname")]
        [Required]
        public string Surname { get; set; }

        [DisplayName("Birthdate")]
        [Required]
        public DateTime Birthdate { get; set; }

        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("InsertDate")]
        [Required]
        public DateTime InsertDate { get; set; }

        [DisplayName("ModifyDate")]
        public DateTime? ModifyDate { get; set; }
    }
}
