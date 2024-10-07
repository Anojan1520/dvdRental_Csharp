
using System.Data.SqlClient;
using WebApplication1.IRepository;
using WebApplication1.Modals;

namespace WebApplication1.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private string _connectionString;

        public NotificationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string AddNotification(Notifications notifications)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                            INSERT INTO Notification(id, RentedId, RentedQuantity, movieId, UserId, RequestDate, Status) 
                            VALUES(@id, @RentedId, @RentedQuantity, @movieId, @UserId, @RequestDate, @Status)";
                command.Parameters.AddWithValue("@id", Guid.NewGuid());
                command.Parameters.AddWithValue("@RentedId", notifications.RentedId);
                command.Parameters.AddWithValue("@RentedQuantity", notifications.RentedQuantity);
                command.Parameters.AddWithValue("@movieId", notifications.movieId);
                command.Parameters.AddWithValue("@UserId", notifications.UserId);
                command.Parameters.AddWithValue("@RequestDate", notifications.RequestDate);
                command.Parameters.AddWithValue("@Status", notifications.Status);

                command.ExecuteNonQuery();

            }
            return "Notification save Successfully..";
        }
    }

}
