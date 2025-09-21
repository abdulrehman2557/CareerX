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
    public class UserEducationService : IEducationService
    {

        private readonly IDBOperation _dbOperation;
        public UserEducationService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task DataEntryUserEducation(UserEducationModel model)
        {
            await _dbOperation.CRUDAsync<UserEducationModel>(model, "SP_InsertUserEducation");
        }


        public async Task<GetUserEducationModel> GetUserEducationAsync(string EducationId)
        {
            var para = new Dictionary<string, object>()
            {
                { "@EducationId", EducationId }
            };
            return await _dbOperation.ReadDataAsync<GetUserEducationModel>("SP_GetUserEducationById", para);
        }

    }
}
