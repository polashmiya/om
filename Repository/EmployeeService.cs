using Microsoft.EntityFrameworkCore;
using OM.DbContexts;
using OM.DTO;
using OM.EmployeeDTO;
using OM.Models;

public class EmployeeService : IEmployee
{
    private readonly Context _context;

    public EmployeeService(Context context)
    {
        _context = context;
    }

    public async Task<MessageHelper> CreateEmployee(EmployeeCreateUpdateDto employee)
    {
        try
        {
            var newEmployee = new Employee
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                DepartmentId = employee.DepartmentId,
                DepartmentName = employee.DepartmentName,
                DesignationId = employee.DesignationId,
                DesignationName = employee.DesignationName,
                MobileNo = employee.MobileNo,
                Emaill = employee.Email,
                JoiningDate = employee.JoiningDate,
                ConfirmationDate = employee.ConfirmationDate ,
                EmployeeTypeId = employee.EmployeeTypeId,
                EmployeeTypeName = employee.EmployeeTypeName,
                OfficeId = employee.OfficeId,
                OfficeName = employee.OfficeName,
                ReligionId = employee.ReligionId,
                ReligionName = employee.ReligionName,
                GenderId = employee.GenderId,
                GenderName = employee.GenderName,
                BloodGroupId = employee.BloodGroupId,
                BloodGroupName = employee.BloodGroupName,
                DateOfBirth = employee.DateOfBirth ?? null,
                OfficialContact = employee.OfficialContact,
                Nid = employee.Nid,
                PresentAddress = employee.PresentAddress,
                PermanentAddress = employee.PermanentAddress,
                SupervisorId = employee.SupervisorId,
                LineManagerId = employee.LineManagerId,
                IsUser = employee.IsUser,
                IsMasterUser = employee.IsMasterUser,
                IsAdmin = employee.IsAdmin
            };
            _context.Employees.Add(newEmployee);
            await _context.SaveChangesAsync();
            return new MessageHelper
            {
                Message = "Employee Created Successfully",
                StatusCode = 200
            };
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
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
