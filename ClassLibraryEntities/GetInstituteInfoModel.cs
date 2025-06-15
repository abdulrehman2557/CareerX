using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEntities
{
    public class GetInstituteInfoModel
    {

        public string? InstId { get; set; }
        public string? InstName { get; set; }

        public string? InstAbbv { get; set; }

        public bool IsMainCampus { get; set; }


        public string? CityName { get; set; }


        public string? InstAddress { get; set; }

        public bool IsActive { get; set; }
    }
}
