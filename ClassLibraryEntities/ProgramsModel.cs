using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class ProgramsModel
    {
        
        [Required]
        public string? Fk_DeptId { get; set; }
        [Required]
        public string? ProgramName { get; set; }
        [Required]
        public string? ProgAbbv { get; set; }
        [Required(ErrorMessage = "Please select a program type.")]
        public int? Fk_ProgramTypeID { get; set; }
    }
}
