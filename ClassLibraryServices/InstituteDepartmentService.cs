using ClassLibraryDAL;
using ClassLibraryEntities;
using Entities;


namespace ClassLibraryServices
{
    public class InstituteDepartmentService : IInstituteDepartmentService
    {
        private readonly IDBOperation  _dbOperation;
       public InstituteDepartmentService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<List<GetInstituteDepartment>> GetDepartmentsByInstId(string id)
        {
            var para = new Dictionary<string, object>()
            {
                {"@InstId", id}
            };
            List<GetInstituteDepartment> models = await  _dbOperation.ReadDataListAsync<GetInstituteDepartment>("SP_GetDepartmentsByInstId", para);
            return models;
        }

        public async Task<IEnumerable<GetInstituteDepartment>> GetAllInstitutesDepartments()
        {
            return await _dbOperation.ReadDataListAsync<GetInstituteDepartment>("SP_GetDepartmentsByInstId");
        }

        public async Task DataEntryInstDepartment(InstituteDepartmentModel model)
        {
            await _dbOperation.CRUDAsync<InstituteDepartmentModel>(model, "SP_InstituteDepartment");
        }
    }
}
