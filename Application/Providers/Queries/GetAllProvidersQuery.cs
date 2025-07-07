using DiligenciaProveedores.Application.DTOs;
using MediatR;

public record GetAllProvidersQuery : IRequest<List<ProviderDto>>;
