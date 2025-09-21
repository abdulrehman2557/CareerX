using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class InstituteProgramsService : IInstituteProgramsService
    {
        private readonly IDBOperation _dBOperation;
        public InstituteProgramsService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

       public async Task<IEnumerable<GetInstituteProgram>> GetInstProgramsByInstId(string instId)
        {
            var para = new Dictionary<string, object>()
            {
                {"@InstId", instId}
            };

            return await _dBOperation.ReadDataListAsync<GetInstituteProgram>("SP_GetProgramsByInstId", para);
        }
    }
}
