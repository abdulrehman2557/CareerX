using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetUserEducationModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "EducationId must be exactly 8 characters.")]
        public string? EducationId { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "PersonalId must be exactly 8 characters.")]
        public string? FK_PersonalId { get; set; }

        [Required]
        public int DegreeTitle { get; set; }

        [Required]
        public int MajorGroup { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "InstitutionID must be exactly 8 characters.")]
        public string? FK_InstitutionID { get; set; }

        [Required]
        public DateTime StartYear { get; set; }

        [Required]
        public DateTime EndYear { get; set; }

        [StringLength(20, ErrorMessage = "CompletionStatus cannot exceed 20 characters.")]
        public string? CompletionStatus { get; set; }

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Total Marks must be a positive decimal value.")]
        public decimal TotalMarks { get; set; }

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Obtained Marks must be a positive decimal value.")]
        public decimal ObtainedMarks { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Country code cannot exceed 5 characters.")]
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }

        public string? CityName { get; set; }

        [Required]
        public int CityCode { get; set; }
    }
}
