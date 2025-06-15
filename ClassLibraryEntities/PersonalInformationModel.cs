using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class PersonalInformationModel
    {
   
       
        [Required]
        [StringLength(100, ErrorMessage = "User ID cannot exceed 100 characters.")]
        public string? FK_UserID { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
        public string? PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^(A|B|AB|O)[+-]$", ErrorMessage = "Invalid blood group format.")]
        [StringLength(3)]
        public string? BloodGroup { get; set; }

        public int? FK_ReligionID { get; set; }

        [Required]
        public bool DisabilityStatus { get; set; }

        [StringLength(5, ErrorMessage = "Country code cannot exceed 5 characters.")]
        public string? FK_CountryCode { get; set; }

        public int? FK_CityID { get; set; }

        [StringLength(20, ErrorMessage = "Area cannot exceed 20 characters.")]
        public string? Area { get; set; }

        [StringLength(50, ErrorMessage = "Location cannot exceed 50 characters.")]
        public string? Location { get; set; }

        [Required]
        public bool IsActive { get; set; }

     
    }
}
