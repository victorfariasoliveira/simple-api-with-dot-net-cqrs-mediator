using MediatR;
using WebApplication1.Domain.Commands.Responses;

namespace WebApplication1.Domain.Commands.Requests
{
    public class CreateCustomerRequest: IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
