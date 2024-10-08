using WebApplication1.IRepository;

namespace WebApplication1.Repository
{
    public class RentedItemsRepository : IRentedItemsRepository
    {

        private string connectionString;

        public RentedItemsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
