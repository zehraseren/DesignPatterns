namespace DP.CQRS.CQRS.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
