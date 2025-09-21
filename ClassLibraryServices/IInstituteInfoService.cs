using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;


namespace Services
{
    public interface IInstituteInfoService
    {
        Task<GetInstituteInfoModel> GetInstituteInfoModelByIdAsync(string InstId);
        Task<IEnumerable<GetInstituteInfoModel>> GetAllInstitutes();
        Task DataEntryInstituteInfo(InstituteInfoModel instituteInfo);
        Task<IEnumerable<GetInstituteInfoModel>> GetInstitutesInfoByCityId(int id);
    }
}
