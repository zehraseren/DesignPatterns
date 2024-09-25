using DP.Observer.DAL;

namespace DP.Observer.Observer
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "MARCH2024",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
