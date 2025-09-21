using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IUserEduSubExperienceService
    {
        Task<GetUserEduSubExperienceModel> GetUserEduSubExperienceAsync(string EduSubExperienceID);
        Task DataEntryUserEduSubExperience(UserEduSubExperienceModel model);
    }
}
