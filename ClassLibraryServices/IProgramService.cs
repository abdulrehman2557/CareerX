using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public interface IProgramService
    {
        Task DataEntryPrograms(ProgramsModel prog);
        Task<IEnumerable<GetProgramsModel>> GetAllPrograms();
        Task<IEnumerable<GetProgramsModel>> GetProgramsByDeptId(string deptId);
        Task<IEnumerable<GetProgramsModel>> GetMastersProgram(string deptId);
        Task<IEnumerable<GetProgramsModel>> GetBachelorsProgram(string deptId);
    }
}
