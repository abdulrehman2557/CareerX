using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IPersonalInformationService
    {
        Task<GetPersonalInformationModel> GetPersonalInformationAsync(string PersonalId);
        Task DataEntryPersonalInfo(PersonalInformationModel model);
    }
    
}
