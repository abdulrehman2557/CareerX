

using ClassLibraryDAL;
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public class CityService: ICityService
    {
        private readonly IDBOperation _dbOperation;
        public CityService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<IEnumerable<CityModel>> GetCities()
        {
            return await _dbOperation.ReadDataListAsync<CityModel>("SP_GetCities");
        }
    }
}
