using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InstituteInfoModel
    {
        [Required(ErrorMessage = "Institute name is required")]
        [StringLength(100, ErrorMessage = "Institute name cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Institute name cannot contain special characters")]
        public string? InstName { get; set; }

        [Required(ErrorMessage = "Institute abbreviation is required")]
        [StringLength(10, ErrorMessage = "Abbreviation cannot exceed 10 characters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Abbreviation cannot contain special characters or spaces")]
        public string? InstAbbv { get; set; }

        public bool IsMainCampus { get; set; }

        [Required(ErrorMessage = "City ID is required")]
        public int Fk_CityId { get; set; }

        [Required(ErrorMessage = "Institute address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        public string? InstAddress { get; set; }

        public bool IsActive { get; set; }

    }
}
