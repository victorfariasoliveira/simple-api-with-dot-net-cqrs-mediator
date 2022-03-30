using MediatR;
using WebApplication1.Domain.Queries.Responses;

namespace WebApplication1.Domain.Queries.Requests
{
    public class FindCustomerByIdRequest: IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}
