using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public interface IDepartmentsService
    {
        Task DataEntryDepartments(DepartmentsModel departments);
        Task<IEnumerable<GetDepartmentModel>> GetAllDepartments();
    }
}
