using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAppointmentServer.WebAPI.Abstractions
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
