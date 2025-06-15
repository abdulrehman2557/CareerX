using System.ComponentModel.DataAnnotations;


namespace Entities
{
    public class InstituteDepartmentModel
    {
        public string? Fk_InstId { get; set; }
        //public string? InstDeptId { get; set; }      

        [Required(ErrorMessage = "Department ID is required.")]
        [StringLength(50, ErrorMessage = "Department ID cannot exceed 50 characters.")]
        public string? Fk_DeptId { get; set; }

        [Required(ErrorMessage = "Custom name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Custom name must be between 3 and 100 characters.")]
        public string? InstDeptCustomName { get; set; }

        [Required(ErrorMessage = "Abbreviation is required.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Abbreviation must be between 2 and 10 characters.")]
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Abbreviation can only contain alphanumeric characters.")]
        public string? InstDeptAbbv { get; set; }
    }
}