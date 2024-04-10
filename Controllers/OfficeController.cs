using Microsoft.AspNetCore.Mvc;
using OM.DTO;

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
        public async Task<IActionResult> CreateOffice(CreateOfficeDTO createOfficeDTO)
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

        [HttpPut("UpdateOffice")]
        public async Task<IActionResult> UpdateOffice(UpdateOfficeDTO updateOfficeDTO)
        {
            try
            {
                var updatedOffice = await _officeService.UpdateOfficeAsync(updateOfficeDTO);
                return Ok(updatedOffice);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("GetOfficeById")]

        public async Task<IActionResult> GetOffice(long officeId)
        {
            try
            {
                var office = await _officeService.GetOfficeByIdAsync(officeId);
                return Ok(office);
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

    }
}