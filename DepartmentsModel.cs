using System.ComponentModel.DataAnnotations;

namespace ClassLibraryEntities
{
    public class DepartmentsModel
    {
        

        [Required(ErrorMessage = "Department Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Department Name must be between 3 and 100 characters.")]
        public string? DeptName { get; set; }

        [Required(ErrorMessage = "Department Abbreviation is required.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Department Abbreviation must be between 2 and 10 characters.")]
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Department Abbreviation can only contain alphanumeric characters.")]
        public string? DeptAbbv { get; set; }

        [Required(ErrorMessage = "Department Active status is required.")]
        public bool DeptIsActive { get; set; }
    }
}