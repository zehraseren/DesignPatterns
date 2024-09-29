using MediatR;

namespace DP.Mediator.Mediator.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
