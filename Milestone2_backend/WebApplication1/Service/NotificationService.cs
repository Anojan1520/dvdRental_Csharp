using WebApplication1.DTO.Request;
using WebApplication1.DTO.Response;
using WebApplication1.IRepository;
using WebApplication1.IService;
using WebApplication1.Modals;
using WebApplication1.Repository;

namespace WebApplication1.Service
{
    public class NotificationService : INotificationService
    {
        private INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        
        public string AddNotification(NotificationRequest notification)
        {
            var obj = new Notifications
            {
                RentedId = notification.RentedId,
                RentedQuantity = notification.RentedQuantity,
                movieId = notification.movieId,
                UserId = notification.UserId,
                RequestDate = notification.RequestDate,
                Status = notification.Status

            };

            var ReturnData = _notificationRepository.AddNotification(obj);
            return ReturnData;

        }

        public List<NotificationResponse> GetNotifications()
        {

        };
    }
}



