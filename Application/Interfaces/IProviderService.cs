using DiligenciaProveedores.Application.DTOs;

namespace DiligenciaProveedores.Application.Interfaces;

public interface IProviderService
{
    Task<List<ProviderDto>> GetAllAsync();
    Task<ProviderDto?> GetByIdAsync(Guid id);
    Task<Guid> CreateAsync(CreateProviderDto dto);
    Task UpdateAsync(UpdateProviderDto dto);
    Task DeleteAsync(Guid id);
}
