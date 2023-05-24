using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Repository
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateNotification(Notification notification)
        {
            Create(notification);
        }
    }
}
