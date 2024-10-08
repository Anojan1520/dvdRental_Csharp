using System.Data.SqlClient;
using WebApplication1.IRepository;
using WebApplication1.Modals;

namespace WebApplication1.Repository
{
    public class ConfirmOrderRepository : IConfirmOrderRepository
    {
        private string _connectionString;

        public ConfirmOrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public string AddConfirmOrder(ConfirmOrders confirmOrders)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                                        INSERT INTO ConfirmOrders(id, Movie, TotalRent, UserId, RentedDate, ReturnDate, MovieId)
                                        VALUES(@id, @Movie, @TotalRent, @UserId, @RentedDate, @ReturnDate, @MovieId);
                                        ";

                command.Parameters.AddWithValue("@id", Guid.NewGuid());
                command.Parameters.AddWithValue("@Movie", confirmOrders.Movie);
                command.Parameters.AddWithValue("@TotalRent", confirmOrders.TotalRent);
                command.Parameters.AddWithValue("@UserId", confirmOrders.UserId);
                command.Parameters.AddWithValue("@RentedDate", confirmOrders.RentedDate);
                command.Parameters.AddWithValue("@ReturnDate", confirmOrders.ReturnDate);
                command.Parameters.AddWithValue("@MovieId", confirmOrders.MovieId);
                
                command.ExecuteNonQuery();

            }
            return "ConfirmOrder Added SuccessFully....";
        }
    }
}
