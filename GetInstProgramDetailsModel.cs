using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetInstProgramDetailsModel
    {
      
            public string? ProgAbbv { get; set; } // Program Abbreviation
            public string? ProgramName { get; set; } // Full Name of the Program
            public int Semsters { get; set; } // Total Semesters
            public int Years { get; set; } // Duration in Years
            public int ExpectedSemFee { get; set; } // Expected Semester Fee
            public int PerChrFee { get; set; } // Fee Per Credit Hour
            public string? ProgShift { get; set; } // Program Shift (Morning/Evening)
            public int LastMerit { get; set; }
            public DateTime UpComingAddDate { get; set; } // Upcoming Admission Date
            public bool IsHECApproved { get; set; } // HEC Approval Status
            public bool IsPECApproved { get; set; } // PEC Approval Status
            public bool IsNESECApproved { get; set; } // NESEC Approval Status
            public bool IsAdmissionOpen { get; set; } // Admission Open Status
        

    }
}
