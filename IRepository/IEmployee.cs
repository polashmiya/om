using OM.DTO;
using OM.EmployeeDTO;

public interface IEmployee
{
    Task<List<CommonDDLDTO>> GetGenderDDL();

    Task<List<CommonDDLDTO>> GetBloodGroupDDL();

    Task<List<CommonDDLDTO>> GetDesignationDDL();

    Task<List<CommonDDLDTO>> GetDepartmentDDL();

    Task<List<CommonDDLDTO>> GetReligionDDL();

    Task<MessageHelper> CreateEmployee(EmployeeCreateUpdateDto employee);
}
