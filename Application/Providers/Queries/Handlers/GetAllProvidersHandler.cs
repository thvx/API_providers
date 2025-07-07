using AutoMapper;
using DiligenciaProveedores.Application.DTOs;
using DiligenciaProveedores.Domain.Interfaces;
using MediatR;

public class GetAllProvidersHandler : IRequestHandler<GetAllProvidersQuery, List<ProviderDto>>
{
    private readonly IProviderRepository _repository;
    private readonly IMapper _mapper;

    public GetAllProvidersHandler(IProviderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProviderDto>> Handle(GetAllProvidersQuery request, CancellationToken cancellationToken)
    {
        var providers = await _repository.GetAllAsync();
        return _mapper.Map<List<ProviderDto>>(providers);
    }
}
