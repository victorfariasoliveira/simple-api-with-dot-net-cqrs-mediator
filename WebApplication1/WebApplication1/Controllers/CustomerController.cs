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
                    [FromServices] IFindCustomerByIdHandler handler,
                    [FromQuery] FindCustomerByIdRequest command)
        {
            var result = handler.Handle(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
                   [FromServices] ICreateCustomerHandler handler,
                   [FromBody] CreateCustomerRequest command )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
