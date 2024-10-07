using WebApplication1.DTO.Request;

namespace WebApplication1.IService
{
    public interface INotificationService
    {
        string AddNotification(NotificationRequest notification);

    }
}
