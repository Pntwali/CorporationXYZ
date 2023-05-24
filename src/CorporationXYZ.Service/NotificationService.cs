using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;
using Hangfire;

namespace CorporationXYZ.Service
{
    public class NotificationService : INotificationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        

        public NotificationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(Notification notification)
        {
            
            _repository.NotificationRepository.CreateNotification(notification);
            await _repository.SaveAsync();
        }

        public async Task SendEmailNotification(EmailNotificationDto Notification)
        {
            // Map the notification to EmailNotificationDto using AutoMapper
            var emailNotificationDto = _mapper.Map<Notification>(Notification);

            // Simulate sending the email notification
            Console.WriteLine("Sending email notification:");
            Console.WriteLine($"Recipient: {emailNotificationDto.Recipient}");
            Console.WriteLine($"Subject: {emailNotificationDto.Subject}");
            Console.WriteLine($"Body: {emailNotificationDto.Body}");
            Console.WriteLine("Email notification sent.");
            Console.WriteLine();
            await AddAsync(emailNotificationDto);
        }

        public Task SendNotificationAsync(Guid userId, NotificationCreateDto notificationCreateDto)
        {
            throw new NotImplementedException();
        }

        public async Task SendSmsNotification(SmsNotificationDto smsDto)
        {

            // Map the notification to SmsNotificationDto using AutoMapper
            var smsNotificationDto = _mapper.Map<Notification>(smsDto);

            // Simulate sending the SMS notification
            Console.WriteLine("Sending SMS notification:");
            Console.WriteLine($"Recipient: {smsNotificationDto.Recipient}");
            Console.WriteLine($"Message: {smsNotificationDto.Message}");
            Console.WriteLine("SMS notification sent.");
            Console.WriteLine();
            await AddAsync(smsNotificationDto);
        }

        private async Task<bool> CheckQuotaAsync(Guid userId)
        {
            var quota = await _repository.QuotaRepository.GetUserQuotaAsync(userId);
            if (quota == null)
            {
                return true;
            }
            int requestCount = await _repository.UsageStatisticsRepository.GetUserCurrentRequestCounts(userId);

            return requestCount < quota.MaxRequestsPerMonth;
        }

        // Implement the service interface members here
    }
}
