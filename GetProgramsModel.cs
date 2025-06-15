using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetProgramsModel
    {
        public string? ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgAbbv { get; set; }
        public string? ProgramType { get; set; }
    }
}
