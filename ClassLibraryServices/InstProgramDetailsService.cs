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
    public class InstProgramDetailsService : IInstProgramDetailsService
    {
        private readonly IDBOperation _dBOperation;
        public InstProgramDetailsService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task DataEntryInstProgramDetails(InstProgramDetailsModel model)
        {
            await _dBOperation.CRUDAsync<InstProgramDetailsModel>(model, "SP_DataEntryInstProgramDetails");
        }

        public async Task<IEnumerable<GetInstProgramDetailsModel>> GetDetailsByInstId(string instId)
        {
            var para = new Dictionary<string, object>()
            {
                {"@InstId", instId}

            };

            return await  _dBOperation.ReadDataListAsync<GetInstProgramDetailsModel>("SP_GetProgramDetails", para);
        }
    }
}
