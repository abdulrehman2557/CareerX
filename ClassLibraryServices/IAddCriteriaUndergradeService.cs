using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IAddCriteriaUndergradeService
    {
        Task<List<AddCriteriaUndergradeModel>> GetUndergradeProgramsByDeatils(decimal MatricPercentage, int MatricDivision, decimal InterPercentage, string InterGroup, int InterDivision);
        Task DataEntryUnderGradeCriteria(UnderGradeCriteriaModel underGradeCriteria);
        Task<IEnumerable<GetUnderGradeCriteriaModel>> GetCriteriaByInstId(string instid);
    }
}
