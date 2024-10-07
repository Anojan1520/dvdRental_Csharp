using WebApplication1.IRepository;
using WebApplication1.IService;

namespace WebApplication1.Service
{
    public class ConfirmOrderService : IConfirmOrderService
    {
        private IConfirmOrderRepository _confirmOrderRepository;

        public ConfirmOrderService(IConfirmOrderRepository confirmOrderRepository)
        {
            _confirmOrderRepository = confirmOrderRepository;
        }
    }
}
