using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IUserEducationExperienceService
    {
        Task DataEntryUserEducationExperience(UserEducationExperienceModel model);
        Task<GetUserEducationExperienceModel> GetUserEducationExperienceAsync(string EducationalExperienceId);
    }
}
