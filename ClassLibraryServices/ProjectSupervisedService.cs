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
    public class ProjectSupervisedService: IProjectSupervisedService
    {

        private readonly IDBOperation _dbOperation;
        public ProjectSupervisedService(IDBOperation dbOperation)
        {
            _dbOperation = dbOperation;
        }

        public async Task<GetProjectSupervisedModel> GetProjectSupervisedAsync(string ProjectSupervisedID)
        {
            var para = new Dictionary<string, object>()
            {
                { "@ProjectSupervisedID", ProjectSupervisedID }
            };
            return await _dbOperation.ReadDataAsync<GetProjectSupervisedModel>("SP_GetProjectSupervisedById", para);
        }

        public async Task DataEntryProjectSupervised(ProjectSupervisedModel model)
        {
            await _dbOperation.CRUDAsync<ProjectSupervisedModel>(model, "SP_InsertProjectSupervised");
        }
    }
}
