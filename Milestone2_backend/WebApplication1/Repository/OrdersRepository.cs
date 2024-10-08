using WebApplication1.IRepository;
using WebApplication1.Modals;

namespace WebApplication1.Repository
{
    public class OrdersRepository: IOrdersRepository
    {
        private string connectionString;

        public OrdersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //public  async Task<IEnumerable<Orders>> GetAllOrders()
        //{
        //    return await connectionString.
        //}
    }
}
