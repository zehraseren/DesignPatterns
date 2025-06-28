using DP.Facade.DAL;

namespace DP.Facade.Facade
{
    public class AddOrderDetail
    {
        Context context = new Context();

        public void AddNewORderDetail(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
