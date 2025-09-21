using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class DepartmentsService : IDepartmentsService
    {
        private readonly IDBOperation _dBOperation;
        public DepartmentsService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task DataEntryDepartments(DepartmentsModel departments)
        {
            await _dBOperation.CRUDAsync<DepartmentsModel>(departments, "SP_DataEntryDepartments");
        }

        public async Task<IEnumerable<GetDepartmentModel>> GetAllDepartments()
        {
          return  await _dBOperation.ReadDataListAsync<GetDepartmentModel>("SP_GetAllDepartments");
        }
    }
}
