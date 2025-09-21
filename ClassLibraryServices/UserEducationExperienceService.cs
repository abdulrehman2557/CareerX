using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public class UserEducationExperienceService : IUserEducationExperienceService
    {


        private readonly IDBOperation _dbOperation;
        public UserEducationExperienceService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }


        public async Task DataEntryUserEducationExperience(UserEducationExperienceModel model)
        {
            await _dbOperation.CRUDAsync<UserEducationExperienceModel>(model, "SP_InsertUserEducationalExperience");
        }


        public async Task<GetUserEducationExperienceModel> GetUserEducationExperienceAsync(string EducationalExperienceid)
        {
            var para = new Dictionary<string, object>()
            {
                {"@EducationalExperienceid", EducationalExperienceid }
            };
            return await _dbOperation.ReadDataAsync<GetUserEducationExperienceModel>("SP_GetUserEducationalExperienceById", para);
        }

    }
}