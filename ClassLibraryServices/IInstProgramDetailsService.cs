using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IInstProgramDetailsService
    {
        Task DataEntryInstProgramDetails(InstProgramDetailsModel model);
        Task<IEnumerable<GetInstProgramDetailsModel>> GetDetailsByInstId(string instId);
    }
}
