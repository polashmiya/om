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
        };

        _context.Offices.Add(office);
        await _context.SaveChangesAsync();

        var officeDTO = new OfficeDTO
        {
            OfficeId = office.Id,
            OfficeName = office.Name,
        };

        return officeDTO;
    }

    public async Task<OfficeDTO> UpdateOfficeAsync(UpdateOfficeDTO updateOfficeDTO)
    {
        var office = await _context.Offices.FindAsync(updateOfficeDTO.OfficeId);

        if (office == null)
        {
            throw new InvalidOperationException("Office not found.");
        }

        office.Name = updateOfficeDTO.OfficeName;

        await _context.SaveChangesAsync();

        var officeDTO = new OfficeDTO
        {
            OfficeId = office.Id,
            OfficeName = office.Name,
        };

        return officeDTO;
    }

    public async Task<OfficeDTO> GetOfficeByIdAsync(long officeId)
    {
        var officeData = await Task.FromResult((from o in _context.Offices
                                                where o.Id == officeId
                                                select new OfficeDTO()
                                                {
                                                    OfficeId = o.Id,
                                                    OfficeName = o.Name
                                                }).FirstOrDefault()) ?? throw new InvalidOperationException("Office not found.");

        return officeData;
    }
}