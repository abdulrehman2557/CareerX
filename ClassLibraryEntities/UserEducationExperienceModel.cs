using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserEducationExperienceModel
    {
      

        [Required, StringLength(8, MinimumLength = 8)]
        public string? FK_PersonalId { get; set; }

        [Required, StringLength(8, MinimumLength = 8)]
        public string? InstitutionID { get; set; }

        [Required]
        public int FK_DesignationID { get; set; }

        [Required]
        public int FK_EmploymentType { get; set; }

        [Required]
        public int FK_TeachingMode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public bool IsCurrentJob { get; set; }
    }
}
