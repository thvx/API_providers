using DiligenciaProveedores.Domain.Entities;

namespace DiligenciaProveedores.Domain.Interfaces;

public interface IProviderRepository
{
    Task<Provider?> GetByIdAsync(Guid id);
    Task<List<Provider>> GetAllAsync();
    Task AddAsync(Provider provider);
    Task UpdateAsync(Provider provider);
    Task DeleteAsync(Guid id);
    Task<bool> ExistsByTaxIdAsync(string taxId);
}
