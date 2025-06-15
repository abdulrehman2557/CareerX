using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class PostGradeCriteriaModel
    {
        [Required(ErrorMessage = "Institution ID is required")]
        public string? Fk_InstId { get; set; }

        [Required(ErrorMessage = "Program ID is required")]
        public string? Fk_ProgramId { get; set; }

        [Required(ErrorMessage = "Institute Department ID is required")]
        public string? Fk_InstDeptId { get; set; }

        [Key]
        public string? PostGradeCriteriaId { get; set; }

        [Required(ErrorMessage = "Matric Percentage is required")]
        [Range(0, 100, ErrorMessage = "Matric Percentage must be between 0 and 100")]
        public decimal? MatricPercentage { get; set; }

        [Required(ErrorMessage = "Matric division is required")]
        [Range(1, 3, ErrorMessage = "Matric division must be between 1 and 3")]
        public int MatricDivision { get; set; }


        [Required(ErrorMessage = "Intermediate Percentage is required")]
        [Range(0, 100, ErrorMessage = "Intermediate percentage must be between 0 and 100")]
        public decimal? InterPercentage { get; set; }

        [Required(ErrorMessage = "Intermediate division is required")]
        [Range(1, 3, ErrorMessage = "Intermediate division must be between 1 and 3")]
        public int InterDivision { get; set; }


        [Required(ErrorMessage = "Bachelor's GPA is required")]
        [Range(0, 4, ErrorMessage = "Bachelor's GPA must be between 0 and 4")]
        public decimal? BachelorsGPA { get; set; }

        [Required(ErrorMessage = "Bachelor's Percentage is required")]
        [RegularExpression(@"^\d{1,3}(\.\d{1,2})?$", ErrorMessage = "Invalid bachelor's percentage format")]
        public string? BachelorsPercentage { get; set; }

        [Required(ErrorMessage = "Bachelor's division is required")]
        [Range(1, 3, ErrorMessage = "Bachelor's division must be between 1 and 3")]
        public int BachelorsDivision { get; set; }
    }
}
