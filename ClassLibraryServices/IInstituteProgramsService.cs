using ClassLibraryEntities;

namespace ClassLibraryServices
{
    public interface IInstituteProgramsService
    {
        Task<IEnumerable<GetInstituteProgram>> GetInstProgramsByInstId(string  instId);
    }
}
