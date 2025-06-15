using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class ProjectSupervisedModel
    {

       

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "FK_PersonalId must be 8 characters long.")]
        public string? FK_PersonalId { get; set; }

        [Required]
        public int FK_ProgramTypeID { get; set; }

        [Required]
        public int FK_DegreeTitleID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "ProjectTitle cannot exceed 50 characters.")]
        public string? ProjectTitle { get; set; }

        [Required]
        public int FK_TechnologyID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "NumberOfStudents must be greater than zero.")]
        public int NumberOfStudents { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "Year must be a valid year.")]
        public int Year { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "ShortDescription cannot exceed 255 characters.")]
        public string? ShortDescription { get; set; }
    }
}
