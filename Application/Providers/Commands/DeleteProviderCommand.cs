using MediatR;

public record DeleteProviderCommand(Guid Id) : IRequest;
