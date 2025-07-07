using DiligenciaProveedores.Domain.Entities;
using DiligenciaProveedores.Domain.Interfaces;
using DiligenciaProveedores.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DiligenciaProveedores.Persistence.Repositories;

public class ProviderRepository : IProviderRepository
{
    private readonly ApplicationDbContext _context;

    public ProviderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Provider?> GetByIdAsync(Guid id)
    {
        return await _context.Providers.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<Provider>> GetAllAsync()
    {
        return await _context.Providers
            .OrderByDescending(p => p.LastModified)
            .ToListAsync();
    }

    public async Task AddAsync(Provider provider)
    {
        await _context.Providers.AddAsync(provider);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Provider provider)
    {
        _context.Providers.Update(provider);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Providers.FirstOrDefaultAsync(p => p.Id == id);
        if (entity != null)
        {
            _context.Providers.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> ExistsByTaxIdAsync(string taxId)
    {
        return await _context.Providers.AnyAsync(p => p.TaxId == taxId);
    }
}
