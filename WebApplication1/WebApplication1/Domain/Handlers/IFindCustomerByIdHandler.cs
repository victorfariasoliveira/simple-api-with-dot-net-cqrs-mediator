using WebApplication1.Domain.Queries.Requests;
using WebApplication1.Domain.Queries.Responses;

namespace WebApplication1.Domain.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);
    }
}
