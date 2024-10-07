
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


        public List<Notifications> GetNotifications()
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText  = @"SELECT id, RentedId, RentedQuantity, movieId, UserId, RequestDate, Status FROM  Notification";
                var notifications = new List<Notifications>();
                using(var reader  = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new Notifications
                        {
                            id = reader.GetGuid(0),
                            RentedId = reader.GetGuid(1),
                            RentedQuantity = reader.GetInt32(2),
                            movieId = reader.GetGuid(3),
                            UserId = reader.GetGuid(4),
                            RequestDate = reader.GetString(5),
                            Status = reader.GetString(6)
                        };

                        notifications.Add(obj);

                    };

                    return notifications;
                }


            }
        }
    }

}
