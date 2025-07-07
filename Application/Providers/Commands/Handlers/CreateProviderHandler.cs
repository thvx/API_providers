using AutoMapper;
using DiligenciaProveedores.Domain.Entities;
using DiligenciaProveedores.Domain.Enums;
using DiligenciaProveedores.Domain.Interfaces;
using MediatR;

public class CreateProviderHandler : IRequestHandler<CreateProviderCommand, Guid>
{
    private readonly IProviderRepository _repository;
    private readonly IMapper _mapper;

    public CreateProviderHandler(IProviderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
    {
        var dto = request.Dto;

        var provider = new Provider
        {
            Id = Guid.NewGuid(),
            BusinessName = dto.BusinessName,
            TradeName = dto.TradeName,
            TaxId = dto.TaxId,
            PhoneNumber = dto.PhoneNumber,
            Email = dto.Email,
            Website = dto.Website,
            Address = dto.Address,
            Country = Enum.TryParse<Country>(dto.Country, out var country) ? country : Country.Otro,
            AnnualBillingUSD = dto.AnnualBillingUSD,
            LastModified = DateTime.UtcNow
        };

        await _repository.AddAsync(provider);
        return provider.Id;
    }
}
