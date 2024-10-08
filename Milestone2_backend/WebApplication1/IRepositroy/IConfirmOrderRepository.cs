using WebApplication1.Modals;

namespace WebApplication1.IRepository
{
    public interface IConfirmOrderRepository
    {
        string AddConfirmOrder(ConfirmOrders confirmOrders);
    }
}
