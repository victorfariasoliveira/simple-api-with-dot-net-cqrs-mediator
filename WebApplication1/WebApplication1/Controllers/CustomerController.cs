using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Commands.Requests;
using WebApplication1.Domain.Handlers;
using WebApplication1.Domain.Queries.Requests;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetById(
                    [FromServices] IMediator mediator,
                    [FromQuery] FindCustomerByIdRequest command)
        {
            var result = mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
                   [FromServices] IMediator mediator,
                   [FromBody] CreateCustomerRequest command )
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}
