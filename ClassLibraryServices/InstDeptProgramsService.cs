using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using Entities;

namespace ClassLibraryServices
{
    public class InstDeptProgramsService : IInstDeptProgramsService
    {
        private readonly IDBOperation _dBOperation;
        public InstDeptProgramsService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }
        
        public async Task DataEntryInstDeptPrograms(InstDeptProgramsModel model)
        {
            await _dBOperation.CRUDAsync<InstDeptProgramsModel>(model, "SP_DataEntryInstDeptProgs");
        }
    }
}
