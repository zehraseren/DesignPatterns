using MediatR;
using DP.Mediator.Mediator.Results;

namespace DP.Mediator.Mediator.Queries
{
    public class GettAllProductQuery : IRequest<List<GetAllProductQueryResult>>
    {
    }
}
