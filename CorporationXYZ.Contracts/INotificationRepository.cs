using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface INotificationRepository
    {
        void CreateNotification(Notification notification);
    }
}
