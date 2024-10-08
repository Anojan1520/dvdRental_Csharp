using WebApplication1.DTO.Request;
using WebApplication1.IRepository;
using WebApplication1.IService;
using WebApplication1.Modals;

namespace WebApplication1.Service
{
    public class ConfirmOrderService : IConfirmOrderService
    {
        private IConfirmOrderRepository _confirmOrderRepository;

        public ConfirmOrderService(IConfirmOrderRepository confirmOrderRepository)
        {
            _confirmOrderRepository = confirmOrderRepository;
        }


        public string AddConfirmOrder(ConfirmOrderRequest confirmOrderRequest)
        {
            var obj = new ConfirmOrders
            {
                Movie = confirmOrderRequest.Movie,
                TotalRent = confirmOrderRequest.TotalRent,
                UserId = confirmOrderRequest.UserId,
                RentedDate = confirmOrderRequest.RentedDate,
                ReturnDate = confirmOrderRequest.ReturnDate,
                MovieId = confirmOrderRequest.MovieId
            };

            var data = _confirmOrderRepository.AddConfirmOrder(obj);
            return data;
        }
    }
}
