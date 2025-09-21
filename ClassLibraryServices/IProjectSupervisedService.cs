using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntities;
using Entities;

namespace ClassLibraryServices
{
    public interface IProjectSupervisedService
    {
        Task<GetProjectSupervisedModel> GetProjectSupervisedAsync(string ProjectSupervisedID);
        Task DataEntryProjectSupervised(ProjectSupervisedModel model);
    }
}
