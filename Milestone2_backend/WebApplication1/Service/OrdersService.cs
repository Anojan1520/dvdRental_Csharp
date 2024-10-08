using WebApplication1.IRepository;
using WebApplication1.IService;

namespace WebApplication1.Service
{
    public class OrdersService : IOrdersService
    {
        private IOrdersRepository ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }
    }
}
