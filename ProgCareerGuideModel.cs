using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProgCareerGuideModel
    {
        [Required(ErrorMessage = "Program ID is required")]
        public string? Fk_ProgramId { get; set; }

        [Key]
        public string? CGId { get; set; }

        [Required(ErrorMessage = "Details are required")]
        [StringLength(1000, ErrorMessage = "Details cannot exceed 1000 characters")]
        public string? Details { get; set; }
    }
}
