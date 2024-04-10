using Microsoft.EntityFrameworkCore;
using OM.DbContexts;
using OM.DTO;

public class EmployeeService : IEmployee
{
    private readonly Context _context;

    public EmployeeService(Context context)
    {
        _context = context;
    }

    public async Task<List<CommonDDLDTO>> GetBloodGroupDDL()
    {
        try
        {
            var bloodGroupData = await _context
                .BloodGroups.Select(b => new CommonDDLDTO
                {
                    Label = b.BloodGroupName,
                    Value = b.BloodGroupId
                })
                .ToListAsync();
            return bloodGroupData;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<List<CommonDDLDTO>> GetDepartmentDDL()
    {
        try
        {
            var departmentData = await _context
                .Departments.Select(d => new CommonDDLDTO
                {
                    Value = d.DepartmentId,
                    Label = d.DepartmentName
                })
                .ToListAsync();

            return departmentData;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<List<CommonDDLDTO>> GetDesignationDDL()
    {
        try
        {
            var designationData = await _context
                .Designations.Select(d => new CommonDDLDTO
                {
                    Label = d.DesignationName,
                    Value = d.DesignationId
                })
                .ToListAsync();
            return designationData;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<List<CommonDDLDTO>> GetGenderDDL()
    {
        try
        {
            var genderData = await _context
                .Genders.Select(g => new CommonDDLDTO { Label = g.GenderName, Value = g.GenderId })
                .ToListAsync();
            return genderData;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<List<CommonDDLDTO>> GetReligionDDL()
    {
        try
        {
            var religionData = await _context
                .Religions.Select(r => new CommonDDLDTO
                {
                    Label = r.ReligionName,
                    Value = r.ReligionId
                })
                .ToListAsync()
                .ConfigureAwait(false);
            return religionData;
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
    }
}
