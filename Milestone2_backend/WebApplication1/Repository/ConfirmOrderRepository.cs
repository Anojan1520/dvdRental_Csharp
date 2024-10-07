using WebApplication1.IRepository;

namespace WebApplication1.Repository
{
    public class ConfirmOrderRepository : IConfirmOrderRepository
    {
        private string _connectionString;

        public ConfirmOrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
