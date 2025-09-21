
using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetCities();

    }
}
