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
    public class PersonalInformationService: IPersonalInformationService
    {
        private readonly IDBOperation _dbOperation;
        public PersonalInformationService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

       public async Task<GetPersonalInformationModel> GetPersonalInformationAsync(string PersonalId)
        {
            var para = new Dictionary<string, object>()
            {
                { "@PersonalId", PersonalId }
            };
          return await _dbOperation.ReadDataAsync<GetPersonalInformationModel>( "SP_GetPersonalInfoById",para );
        }

        public async Task DataEntryPersonalInfo(PersonalInformationModel model)
        {
            await _dbOperation.CRUDAsync<PersonalInformationModel>(model, "SP_AddPersonalInfo");
        }
    }
}
