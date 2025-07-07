using DiligenciaProveedores.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiligenciaProveedores.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProvidersController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProvidersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Authorize(Roles = "User, Admin")]
    [HttpGet]
    public async Task<ActionResult<List<ProviderDto>>> GetAll()
    {
        var result = await _mediator.Send(new GetAllProvidersQuery());
        return Ok(result);
    }

    [Authorize(Roles = "User, Admin")]
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ProviderDto>> GetById(Guid id)
    {
        var result = await _mediator.Send(new GetProviderByIdQuery(id));
        return Ok(result);
    }

    [Authorize(Roles = "User, Admin")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProviderCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [Authorize(Roles = "User, Admin")]
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProviderCommand command)
    {
        if (id != command.Dto.Id) return BadRequest("Id mismatch.");
        await _mediator.Send(command);
        return NoContent();
    }

    [Authorize(Roles = "User, Admin")]
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _mediator.Send(new DeleteProviderCommand(id));
        return NoContent();
    }
}
