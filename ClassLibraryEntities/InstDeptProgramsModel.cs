using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InstDeptProgramsModel
    {
        [Required(ErrorMessage = "Institute Department ID is required.")]
        public string? Fk_InstDeptId { get; set; }

        [Required(ErrorMessage = "Program ID is required.")]
        public string? Fk_ProgramId { get; set; }
    }
}