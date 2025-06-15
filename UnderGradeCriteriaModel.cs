using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class UnderGradeCriteriaModel
    {
        //[Required(ErrorMessage = "Criteria ID is required.")]
        //public string? AddCriteriaUndergradeId { get; set; }

        [Required(ErrorMessage = "Institute ID is required.")]
        public string? Fk_InstId { get; set; }

        [Required(ErrorMessage = "Institute Department ID is required.")]
        public string? Fk_InsDepartId { get; set; }

        [Required(ErrorMessage = "Program ID is required.")]
        public string? Fk_ProgramId { get; set; }

        [Required(ErrorMessage = "Matric Percentage is required.")]
        [Range(0, 100, ErrorMessage = "Matric Percentage must be between 0 and 100.")]
        public decimal? MatricPercentage { get; set; }

        [Required(ErrorMessage = "Matric Division is required.")]
        [Range(1, 3, ErrorMessage = "Matric Division must be between 1 and 3.")]
        public int MatricDivision { get; set; }

        [Required(ErrorMessage = "Intermediate Percentage is required.")]
        [Range(0, 100, ErrorMessage = "Intermediate Percentage must be between 0 and 100.")]
        public decimal? InterPercentage { get; set; }

        [Required(ErrorMessage = "Intermediate Division is required.")]
        [Range(1, 3, ErrorMessage = "Intermediate Division must be between 1 and 3.")]
        public int InterDivision { get; set; }

        [Required(ErrorMessage = "Intermediate Group is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Intermediate Group must be between 2 and 50 characters.")]
        public string? InterGroup { get; set; }
    }
}
