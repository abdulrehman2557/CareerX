using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class ProgramTypeService:IProgramType
    {
        private readonly IDBOperation _dbOperation;
        public ProgramTypeService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }


        public async Task<IEnumerable<ProgramTypeModel>> GetProgramType()
        {
            return await _dbOperation.ReadDataListAsync<ProgramTypeModel>("SP_GetProgramTypes");
        }
    }
}
