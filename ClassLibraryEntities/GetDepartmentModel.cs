using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetDepartmentModel
    {
        public string? DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? DeptAbbv { get; set; }
        public bool DeptIsActive { get; set; }
    }
}
