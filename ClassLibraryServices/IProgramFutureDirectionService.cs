using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public interface IProgramFutureDirectionService
    {
        Task<GetProgCareerGuideModel> GetFutureDirectionByProgramId(string ProgramId);
    }
}
