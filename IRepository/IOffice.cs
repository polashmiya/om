using OM.DTOs;

public interface IOffice
{
    Task<List<OfficeDTO>> GetOfficesAsync();
    Task<OfficeDTO> CreateOfficeAsync(CreateOfficeDTO createOfficeDTO);

    Task<OfficeDTO> UpdateOfficeAsync(UpdateOfficeDTO updateOfficeDTO);

    Task<OfficeDTO> GetOfficeByIdAsync(long officeId);

}