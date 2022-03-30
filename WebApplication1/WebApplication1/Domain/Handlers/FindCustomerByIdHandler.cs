using WebApplication1.Domain.Queries.Requests;
using WebApplication1.Domain.Queries.Responses;

namespace WebApplication1.Domain.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        // ICustomerRepository _repository;

        public FindCustomerByIdHandler(/*ICustomerRepository repository*/)
        {
            //_repository = repository;
        }
        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            return new FindCustomerByIdResponse { Email = "", Id = Guid.NewGuid(), Name = "" }; 
            // return _repository.GetCustomerById(command.Id);
        }
    }
}
