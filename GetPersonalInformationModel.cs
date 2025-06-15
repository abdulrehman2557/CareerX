using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetPersonalInformationModel
    {

        
        
            public string? PersonalId { get; set; }
            public string? FK_UserID { get; set; }
            public string? PhoneNumber { get; set; }
            public string? BloodGroup { get; set; }
            public string? ReligionName { get; set; }
            public bool DisabilityStatus { get; set; }
            public string? CountryName { get; set; }
            public int CountryCode { get; set; }
            public string? CityName { get; set; }
            public int CityCode { get; set; }
            public string? Area { get; set; }
            public string? Location { get; set; }
            public bool IsActive { get; set; }
            public DateTime CreatedAt { get; set; }
            public string? LastUpdate { get; set; } 
        


    }
}
