using WebApplication1.IRepository;
using WebApplication1.IService;

namespace WebApplication1.Service
{
    public class RentedItemsService : IRentedItemsService
    {
        private IRentedItemsRepository rentedItemsRepository;

        public RentedItemsService(IRentedItemsRepository rentedItemsRepository)
        {
            this.rentedItemsRepository = rentedItemsRepository;
        }
    }
}
