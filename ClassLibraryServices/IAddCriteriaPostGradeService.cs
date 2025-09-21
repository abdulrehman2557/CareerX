using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IAddCriteriaPostGradeService
    {
        Task<List<AddCriteriaPostGradeModel>> GetPostGradeProgramsByDetails(decimal MatricPercentage, int MatricDivision, decimal InterPercentage, int InterDivision, decimal BachelorsGPA, decimal BachelorsPercentage, int BachelorsDivision);
        Task DataEntryPostGradeCriteria(PostGradeCriteriaModel postGradeCriteria);
        Task<IEnumerable<GetPostGradeCriteriaModel>> GetPostCriteriaByInstId(string InstId);
    }
}
