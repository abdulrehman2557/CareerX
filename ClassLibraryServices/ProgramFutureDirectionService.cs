using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class ProgramFutureDirectionService : IProgramFutureDirectionService
    {
        private readonly IDBOperation _dbOperation;
        public ProgramFutureDirectionService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<GetProgCareerGuideModel> GetFutureDirectionByProgramId(string ProgramId)
        {
            var param = new Dictionary<string, object>()
            {
                {
                    "@ProgramId", ProgramId
                }
            };
            return await _dbOperation.ReadDataAsync<GetProgCareerGuideModel>("SP_ProgramFutureDirectionByProgramId", param);
        }
    }
}
