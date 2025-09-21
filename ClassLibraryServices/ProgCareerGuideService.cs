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
    public class ProgCareerGuideService : IProgCareerGuideService
    {
        private readonly IDBOperation _dBOperation;
        public ProgCareerGuideService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task<GetProgCareerGuideModel> GetProgCareerGuide(string ProgId)
        {
            var para = new Dictionary<string, object>()
            {
                {"@ProgramId",ProgId}
            };

            return await _dBOperation.ReadDataAsync<GetProgCareerGuideModel>("SP_GetProgramFutureDirectionByProgramId", para);

        }

        public async Task DataEntryProgCareerGuide(ProgCareerGuideModel progCareerGuideModel)
        {
            await _dBOperation.CRUDAsync<ProgCareerGuideModel>(progCareerGuideModel, "SP_DataEntryProgCareerGuide");
        }
    }
}
