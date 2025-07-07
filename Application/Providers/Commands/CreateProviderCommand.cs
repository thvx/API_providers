using MediatR;

public record CreateProviderCommand(CreateProviderDto Dto) : IRequest<Guid>;
