using Microsoft.AspNetCore.Mvc;
using OM.EmployeeDTO;

namespace OM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeService;

        public EmployeeController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetBloodGroupDDL")]
        public async Task<IActionResult> GetBloodGroupDDL()
        {
            try
            {
                var bloodGroupData = await _employeeService.GetBloodGroupDDL();
                return Ok(bloodGroupData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetGenderDDL")]
        public async Task<IActionResult> GetGenderDDL()
        {
            try
            {
                var genderData = await _employeeService.GetGenderDDL();
                return Ok(genderData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetDepartmentDDL")]
        public async Task<IActionResult> GetDepartmentDDL()
        {
            try
            {
                var departmentData = await _employeeService.GetDepartmentDDL();
                return Ok(departmentData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetReligionDDL")]
        public async Task<IActionResult> GetReligionDDL()
        {
            try
            {
                var religionData = await _employeeService.GetReligionDDL();
                return Ok(religionData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("GetDesignationDDL")]
        public async Task<IActionResult> GetDesignationDDL()
        {
            try
            {
                var designationData = await _employeeService.GetDesignationDDL();
                return Ok(designationData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(EmployeeCreateUpdateDto employee)
        {
            try
            {
                var message = await _employeeService.CreateEmployee(employee);
                return Ok(message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
