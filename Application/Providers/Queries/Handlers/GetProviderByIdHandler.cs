using AutoMapper;
using DiligenciaProveedores.Application.DTOs;
using DiligenciaProveedores.Domain.Interfaces;
using MediatR;

public class GetProviderByIdHandler : IRequestHandler<GetProviderByIdQuery, ProviderDto>
{
    private readonly IProviderRepository _repository;
    private readonly IMapper _mapper;

    public GetProviderByIdHandler(IProviderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ProviderDto> Handle(GetProviderByIdQuery request, CancellationToken cancellationToken)
    {
        var provider = await _repository.GetByIdAsync(request.Id);

        if (provider == null)
            throw new KeyNotFoundException("Proveedor no encontrado.");

        return _mapper.Map<ProviderDto>(provider);
    }
}
