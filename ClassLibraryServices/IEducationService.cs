using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IEducationService
    {
        Task<GetUserEducationModel> GetUserEducationAsync(string EducationId);
        Task DataEntryUserEducation(UserEducationModel model);
    }
}
