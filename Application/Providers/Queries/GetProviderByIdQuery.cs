using DiligenciaProveedores.Application.DTOs;
using MediatR;

public record GetProviderByIdQuery(Guid Id) : IRequest<ProviderDto>;
