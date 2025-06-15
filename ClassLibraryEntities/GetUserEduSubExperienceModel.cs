using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GetUserEduSubExperienceModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "EduSubExperienceID must be exactly 8 characters.")]
        public string? EduSubExperienceID { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "PersonalId must be exactly 8 characters.")]
        public string? FK_PersonalId { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "EducationalExperienceId must be exactly 8 characters.")]
        public string? FK_EducationalExperienceId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Total Teaching Years must be a non-negative integer.")]
        public int TotalTeachingYears { get; set; }

        [Required]
        public int SubjectTaught{ get; set; }

        [Required]
        public int LevelOfTeaching { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Class Size must be at least 1.")]
        public int ClassSize { get; set; }
    }
}
