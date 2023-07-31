using Casgem.ObserverDesingPattern.DAL;

namespace Casgem.ObserverDesingPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "Dergi Ağustos",

            });
        }
    }
}
