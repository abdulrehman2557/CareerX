using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetUnderGradeCriteriaModel
    {
        public string? InstDeptCustomName { get; set; }
        public string? ProgramName { get; set; }
        public decimal MatricPercentage { get; set; }
        public decimal InterPercentage { get; set; }
        public int MatricDivision { get; set; }
        public int InterDivision { get; set; }
    }
}
