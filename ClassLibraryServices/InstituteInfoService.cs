using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL;
using ClassLibraryEntities;
using Entities;

namespace Services
{
    public class InstituteInfoService : IInstituteInfoService
    {
        private readonly IDBOperation _dbOperation;
        public InstituteInfoService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<GetInstituteInfoModel> GetInstituteInfoModelByIdAsync(string InstId)
        {
            var para = new Dictionary<string, object>() {
                {"@InstId",InstId }
            };
            GetInstituteInfoModel model = await _dbOperation.ReadDataAsync<GetInstituteInfoModel>("SP_GetInstituteInfoById", para);
            return model;
        }
        public async Task <IEnumerable<GetInstituteInfoModel>> GetAllInstitutes()
        {
           // var para = new Dictionary<string, object>() { { "@CityID", CityId } };
            return await _dbOperation.ReadDataListAsync<GetInstituteInfoModel>("SP_GetInstituteInfoById");
        }

        public async Task DataEntryInstituteInfo(InstituteInfoModel instituteInfo)
        {
            await _dbOperation.CRUDAsync<InstituteInfoModel>(instituteInfo, "SP_DataEntryInstituteInfo");
            
        }

        public async Task<IEnumerable<GetInstituteInfoModel>> GetInstitutesInfoByCityId(int id)
        {
            var para = new Dictionary<string, object>()
            {
                {"@CityId",id }
            };
            return await _dbOperation.ReadDataListAsync<GetInstituteInfoModel>("SP_GetInstituteInfo", para);
        }
    }
}
