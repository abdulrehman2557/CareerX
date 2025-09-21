using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public class AddCriteriaPostGradeService : IAddCriteriaPostGradeService
    {
        private readonly IDBOperation _dBOperation;

        public AddCriteriaPostGradeService(IDBOperation dBOperation)
        {
            _dBOperation = dBOperation;
        }

        public async Task<List<AddCriteriaPostGradeModel>> GetPostGradeProgramsByDetails(decimal MatricPercentage, int MatricDivision, decimal InterPercentage, int InterDivision, decimal BachelorsGPA, decimal BachelorsPercentage, int BachelorsDivision)
        {
            var para = new Dictionary<string, object>()
            {
                { "@MatricPercentage", MatricPercentage },
                { "@MatricDivision", MatricDivision },
                { "@InterPercentage", InterPercentage },
                { "@InterDivision", InterDivision },
                { "@BachelorsGPA", BachelorsGPA },
                { "@BachelorsPercentage", BachelorsPercentage },
                { "@BachelorsDivision", BachelorsDivision }
            };
            List<AddCriteriaPostGradeModel> model = await _dBOperation.ReadDataListAsync<AddCriteriaPostGradeModel>("SP_GetPostGradeProgramsByUserCriteria", para);
            return model;
        }

        public async Task<IEnumerable<GetPostGradeCriteriaModel>> GetPostCriteriaByInstId(string InstId)
        {
            var para = new Dictionary<string, object>()
            {
                { "@InstId", InstId }
            };
            return await _dBOperation.ReadDataListAsync<GetPostGradeCriteriaModel>("SP_GetPostGradeCriteriaInfo", para);
        }

        public async Task DataEntryPostGradeCriteria(PostGradeCriteriaModel postGradeCriteria)
        {
            await _dBOperation.CRUDAsync<PostGradeCriteriaModel>(postGradeCriteria, "SP_DataEntryPostGradeCriteria");
        }
    }
}
