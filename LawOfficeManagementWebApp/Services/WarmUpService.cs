using LawOfficeManagementWebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagementWebApp.Services;

public class WarmUpService
{
    private readonly ApplicationDbContext _context;

    public WarmUpService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task WarmUpAsync()
    {
        await _context.Clients.Take(1).ToListAsync();
    }
}