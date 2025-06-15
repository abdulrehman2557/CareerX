using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InstProgramDetailsModel
    {
        [Required(ErrorMessage = "Institution ID is required")]
        public string? Fk_InstId { get; set; }

        [Required(ErrorMessage = "Program ID is required")]
        public string? Fk_ProgramId { get; set; }

        [Required(ErrorMessage = "Semesters count is required")]
        [Range(1, 12, ErrorMessage = "Semesters must be between 1 and 12")]
        public int Semsters { get; set; }

        [Required(ErrorMessage = "Years count is required")]
        [Range(1, 6, ErrorMessage = "Years must be between 1 and 6")]
        public int Years { get; set; }

        [Required(ErrorMessage = "Expected semester fee is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Fee must be a positive number")]
        public int ExpectedSemFee { get; set; }

        [Required(ErrorMessage = "Per credit hour fee is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Fee must be a positive number")]
        public int PerChrFee { get; set; }

        [Required(ErrorMessage = "Program shift is required")]
        [StringLength(1, ErrorMessage = "Shift cannot exceed 1 character")]
        public string? ProgShift { get; set; }

        [Required(ErrorMessage = "Last merit is required")]
        [Range(1, 100, ErrorMessage = "Merit must be between 1 and 100")]
        public int LastMerit { get; set; }

        [Required(ErrorMessage = "Upcoming admission date is required")]
        public DateTime UpComingAddDate { get; set; }

        public bool IsHECApproved { get; set; }
        public bool IsPECApproved { get; set; }
        public bool IsNESECApproved { get; set; }
        public bool IsAdmissionOpen { get; set; }
    }
}
