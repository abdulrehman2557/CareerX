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
    public class UserEduSubExperienceService:IUserEduSubExperienceService
    {
        private readonly IDBOperation _dbOperation;
      public UserEduSubExperienceService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<GetUserEduSubExperienceModel> GetUserEduSubExperienceAsync(string EduSubExperienceID)
        {
            var para = new Dictionary<string, object>()
            {
                { "@EduSubExperienceID", EduSubExperienceID }
            };
            return await _dbOperation.ReadDataAsync<GetUserEduSubExperienceModel>("SP_GetUserEduSubExperienceById", para);
        }

        public async Task DataEntryUserEduSubExperience(UserEduSubExperienceModel model)
        {
            await _dbOperation.CRUDAsync<UserEduSubExperienceModel>(model, "SP_InsertUserEduSubExperience");
        }
    }
}
