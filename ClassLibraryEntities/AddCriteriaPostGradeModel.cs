using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AddCriteriaPostGradeModel
    {
        public string? InstName { get; set; }

        public string? ProgramName { get; set; }
        
        public string? InstDeptCustomName { get; set; }

        public int Semesters { get; set; }

        public int Years { get; set; }

        public int ExpectedSemFee { get; set; } 

        public int PerChrFee { get; set; }

        public string? ProgShift { get; set; }

        public int LastMerit { get; set; }

        public DateTime UpComingAddDate { get; set; }

        public bool IsHECApproved { get; set; }

        public bool IsPECApproved { get; set; }

        public bool IsNESECApproved { get; set; }

        public bool IsAdmissionOpen { get; set; }
    }
}
