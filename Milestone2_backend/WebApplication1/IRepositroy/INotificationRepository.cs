﻿using WebApplication1.Modals;

namespace WebApplication1.IRepository
{
    public interface INotificationRepository
    {
        string AddNotification(Notifications notifications);
    }
}
