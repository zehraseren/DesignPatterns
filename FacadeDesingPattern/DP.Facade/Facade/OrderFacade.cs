using DP.Facade.DAL;

namespace DP.Facade.Facade
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            orderDetail.OrderID = orderId;
            orderDetail.CustomerID = customerId;
            orderDetail.ProductID = productId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            decimal totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewORderDetail(orderDetail);

            productStock.DecreaseStock(productId, productCount);
        }

        public void CompleteOrder(int customerId)
        {
            order.CustomerID = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
