using WebApplication1.Domain.Commands.Requests;
using WebApplication1.Domain.Commands.Responses;

namespace WebApplication1.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}
