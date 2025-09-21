using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class ProgramService : IProgramService
    {
        private readonly IDBOperation _dBOperation;
        public ProgramService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task DataEntryPrograms(ProgramsModel prog)
        {
            await _dBOperation.CRUDAsync<ProgramsModel>(prog, "SP_DataEntryPrograms");
        }

        public async Task<IEnumerable<GetProgramsModel>> GetAllPrograms()
        {
            return await _dBOperation.ReadDataListAsync<GetProgramsModel>("SP_GetAllPrograms");
        }

        public async Task<IEnumerable<GetProgramsModel>> GetProgramsByDeptId(string deptId)
        {
            var para = new Dictionary<string, Object>()
            {
                {"@DeptId",deptId },
                
            };
            return await _dBOperation.ReadDataListAsync<GetProgramsModel>("SP_GetAllPrograms", para);
        }

        public async Task<IEnumerable<GetProgramsModel>> GetBachelorsProgram(string deptId)
        {
            int tempp = 1;
            var para = new Dictionary<string, Object>()
            {
                {"@DeptId",deptId },
                {"@ProgramType", tempp }

            };
            return await _dBOperation.ReadDataListAsync<GetProgramsModel>("SP_GetAllPrograms", para);
        }

        public async Task<IEnumerable<GetProgramsModel>> GetMastersProgram(string deptId)
        {
            int tempp = 2;
            var para = new Dictionary<string, Object>()
            {
                {"@DeptId",deptId },
                {"@ProgramType", tempp }

            };
            return await _dBOperation.ReadDataListAsync<GetProgramsModel>("SP_GetAllPrograms", para);
        }
    }
}
