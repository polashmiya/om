using OM.DTO;

public interface IEmployee
{
    Task<List<CommonDDLDTO>> GetGenderDDL();

    Task<List<CommonDDLDTO>> GetBloodGroupDDL();

    Task<List<CommonDDLDTO>> GetDesignationDDL();

    Task<List<CommonDDLDTO>> GetDepartmentDDL();

    Task<List<CommonDDLDTO>> GetReligionDDL();
}
