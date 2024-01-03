using Microsoft.EntityFrameworkCore;
using OM.DbContexts;
using OM.DTOs;
using OM.Models;

public class OfficeService : IOffice
{
    private readonly Context _context;

    public OfficeService(Context context)
    {
        _context = context;
    }

    public async Task<List<OfficeDTO>> GetOfficesAsync()
    {
        try
        {
            var offices = await _context.Offices
            .Select(o => new OfficeDTO { OfficeId = o.Id, OfficeName = o.Name }).ToListAsync();

            return offices;
        }
        catch (System.Exception)
        {

            throw;

        }
    }

    public async Task<OfficeDTO> CreateOfficeAsync(CreateOfficeDTO createOfficeDTO)
    {
        if (_context.Offices.Any(o => o.Name == createOfficeDTO.OfficeName))
        {
            throw new InvalidOperationException("Office with the same name already exists.");
        }
        var office = new Office
        {
            Name = createOfficeDTO.OfficeName,
            // Add other properties as needed
        };

        _context.Offices.Add(office);
        await _context.SaveChangesAsync();

        // Map the created office to OfficeDTO (you can use AutoMapper or manual mapping)
        var officeDTO = new OfficeDTO
        {
            OfficeId = office.Id,
            OfficeName = office.Name,
            // Map other properties as needed
        };

        return officeDTO;
    }
}