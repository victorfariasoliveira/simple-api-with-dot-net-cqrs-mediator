using MediatR;
using WebApplication1.Domain.Queries.Requests;
using WebApplication1.Domain.Queries.Responses;

namespace WebApplication1.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        // ICustomerRepository _repository;

        public FindCustomerByIdHandler(/*ICustomerRepository repository*/)
        {
            //_repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            var result = new FindCustomerByIdResponse { Email = "", Id = Guid.NewGuid(), Name = "" };
            // var result = _repository.GetCustomerById(request.Id);
            return Task.FromResult(result);
        }
    }
}
