using MediatR;
using DP.Mediator.Mediator.Results;

namespace DP.Mediator.Mediator.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<UpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
