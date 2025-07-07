using DiligenciaProveedores.Domain.Interfaces;
using MediatR;

public class DeleteProviderHandler : IRequestHandler<DeleteProviderCommand>
{
    private readonly IProviderRepository _repository;

    public DeleteProviderHandler(IProviderRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteProviderCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repository.GetByIdAsync(request.Id);
        if (existing is null)
            throw new KeyNotFoundException("Proveedor no encontrado.");

        await _repository.DeleteAsync(request.Id);
    }
}
