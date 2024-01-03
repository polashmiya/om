using Microsoft.AspNetCore.Mvc;
using OM.DTOs;

namespace OM.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OfficeController : ControllerBase
    {
        private readonly IOffice _officeService;

        public OfficeController(IOffice officeService)
        {
            _officeService = officeService;
        }

        [HttpGet("GetOffices")]
        public async Task<IActionResult> GetOffices()
        {
            try
            {
                var offices = await _officeService.GetOfficesAsync();
                return Ok(offices);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("CreateOffice")]
        public async Task<IActionResult> CreateOffice([FromBody] CreateOfficeDTO createOfficeDTO)
        {
            try
            {
                var createdOffice = await _officeService.CreateOfficeAsync(createOfficeDTO);
                return Ok(createdOffice);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}