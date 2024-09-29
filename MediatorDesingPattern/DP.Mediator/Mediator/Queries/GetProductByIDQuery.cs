using MediatR;
using DP.Mediator.Mediator.Results;

namespace DP.Mediator.Mediator.Queries
{
    public class GetProductByIDQuery : IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
