using WebApplication1.DTO.Request;

namespace WebApplication1.IService
{
    public interface IConfirmOrderService
    {
        string AddConfirmOrder(ConfirmOrderRequest confirmOrderRequest);
    }
}
