using AutoMapper;
using DiligenciaProveedores.Domain.Enums;
using DiligenciaProveedores.Domain.Interfaces;
using MediatR;

public class UpdateProviderHandler : IRequestHandler<UpdateProviderCommand>
{
    private readonly IProviderRepository _repository;
    private readonly IMapper _mapper;

    public UpdateProviderHandler(IProviderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task Handle(UpdateProviderCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repository.GetByIdAsync(request.Dto.Id) ?? throw new KeyNotFoundException("Proveedor no encontrado.");
        _mapper.Map(request.Dto, existing);
        existing.Country = Enum.TryParse<Country>(request.Dto.Country, out var country) ? country : Country.Otro;
        existing.UpdateLastModified();

        await _repository.UpdateAsync(existing);
    }
}
