using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IInstituteDepartmentService
    {
         Task<List<GetInstituteDepartment>> GetDepartmentsByInstId(string id);
         Task DataEntryInstDepartment(InstituteDepartmentModel model);
    }
}
