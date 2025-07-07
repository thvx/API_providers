using MediatR;

public record UpdateProviderCommand(UpdateProviderDto Dto) : IRequest;
