using OM.DTOs;

public interface IOffice
{
    Task<List<OfficeDTO>> GetOfficesAsync();
    Task<OfficeDTO> CreateOfficeAsync(CreateOfficeDTO createOfficeDTO);

}