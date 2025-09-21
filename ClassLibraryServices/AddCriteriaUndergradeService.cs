

using ClassLibraryDAL;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public class AddCriteriaUndergradeService : IAddCriteriaUndergradeService
    {
        private readonly IDBOperation _dBOperation;

        public AddCriteriaUndergradeService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task<List<AddCriteriaUndergradeModel>> GetUndergradeProgramsByDeatils(decimal MatricPercentage, int MatricDivision, decimal InterPercentage, string InterGroup, int InterDivision)
        {
            var para = new Dictionary<string, object>()
            {
                { "@MatricPercentage", MatricPercentage },
                { "@MatricDivision", MatricDivision },
                { "@InterPercentage", InterPercentage },
                { "@InterGroup", InterGroup },
                { "@InterDivision", InterDivision }
            };
            return await _dBOperation.ReadDataListAsync<AddCriteriaUndergradeModel>("SP_GetUnderGradeProgramsByUserCriteria", para);
            
        }

        public async Task<IEnumerable<GetUnderGradeCriteriaModel>> GetCriteriaByInstId(string instid)
        {
            var para = new Dictionary<string, object>()
            {
                {"@InstId", instid }
            };

            return await _dBOperation.ReadDataListAsync<GetUnderGradeCriteriaModel>("SP_GetUnderGradeCriteriaInfo", para);
        }

        public async Task DataEntryUnderGradeCriteria(UnderGradeCriteriaModel underGradeCriteria)
        {
            await _dBOperation.CRUDAsync<UnderGradeCriteriaModel>(underGradeCriteria, "SP_DataEntryUnderGradeCriteria");
        }
    }
}
