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
                            INSERT INTO Notifications(id, rentedId, rentedQuantity, movieId, UserId, RequestDate, Status) 
                            VALUES(@id, @rentedId, @rentedQuantity, @movieId, @UserId, @RequestDate, @Status)";
                command.Parameters.AddWithValue("@id", Guid.NewGuid());
                command.Parameters.AddWithValue("@rentedId", notifications.rentedId);
                command.Parameters.AddWithValue("@rentedQuantity", notifications.rentedQuantity);
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
