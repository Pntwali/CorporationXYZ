using CorporationXYZ.Entities.Models;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service.Contracts
{
    public interface INotificationService
    {
        Task AddAsync(Notification notificationCreateDto);
        Task SendNotificationAsync(Guid userId, NotificationCreateDto notificationCreateDto);
        // Define the service interface members here
        Task SendSmsNotification(SmsNotificationDto smsDto);
        Task SendEmailNotification(EmailNotificationDto emailDto);
    }
}
