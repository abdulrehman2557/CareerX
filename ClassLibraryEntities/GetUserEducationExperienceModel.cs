using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetUserEducationExperienceModel
    {
        [Required, StringLength(8, MinimumLength = 8)]
        public string? EducationalExperienceId { get; set; }

        [Required, StringLength(8, MinimumLength = 8)]
        public string? FK_PersonalId { get; set; }

        [Required, StringLength(8, MinimumLength = 8)]
        public string? InstitutionID { get; set; }

        [Required]
        public int Designation { get; set; }

        [Required]
        public int EmploymentType { get; set; }

        [Required]
        public int TeachingMode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public bool IsCurrentJob { get; set; }
    }
}
