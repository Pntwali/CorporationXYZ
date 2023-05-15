# System Design of Corporation X,Y,Z Notification Service
## Overview
The system is designed as a distributed microservices-based application. It includes several components, such as the notification API, rate limiter, quota manager, caching service, and database. This design provides a balance between complexity and scalability, allowing the system to handle a large number of requests effectively.

## System Architecture
The system architecture is composed of the following components:

## Notification API (Built with .NET Core)
The Notification API is the entry point for all client requests. It provides endpoints for sending SMS and Email notifications. The API validates incoming requests, checks rate limits and quotas, and forwards valid requests to the appropriate messaging services (SMS and Email services).

## Rate Limiter (Built with AspNetCoreRateLimit)
The rate limiter is integrated into the Notification API. It enforces limits on the number of requests a client can make within a certain time window. If a client exceeds their rate limit, the API responds with a '429 Too Many Requests' status code.

## Quota Manager (Built with .NET Core and SQL Server)
The quota manager keeps track of the number of requests each client has made on a monthly basis. This data is stored in SQL Server. If a client exceeds their monthly quota, the system prevents further requests until the quota resets at the beginning of the next month.

## Caching Service (Built with Redis Cache)
The caching service is also integrated into the Notification API. It caches frequently accessed data, such as client information and request counts, to reduce database load and improve system performance.

## Database (SQL Server)
SQL Server is used to store all persistent data, including client information, quota information, and system logs. The database is designed with considerations for high performance and scalability.

## Load Balancer (Windows Network Load Balancing)
Windows Network Load Balancing (NLB) is used to distribute incoming API requests across multiple servers. This helps prevent any single server from becoming a bottleneck and ensures that the system can handle high traffic loads.

## Messaging Services (Built with .NET Core)
The messaging services are responsible for sending SMS and Email notifications. Each service operates independently, allowing them to be scaled up or down as needed.

## Message Queue (RabbitMQ)
RabbitMQ is used to manage the distribution of tasks to the messaging services. When a notification request is received, it's placed in the message queue and then processed by the appropriate messaging service when it becomes available.

## Containerization (Docker)
Docker is used for containerization. Each component of the application (API, messaging services, etc.) is deployed as a separate container, providing a consistent environment and making it easier to manage and scale the application.

## Monitoring and Logging (.NET Core)
.NET Core's built-in logging is used to track events and errors throughout the system. This information is stored in the SQL Server database and can be used for debugging and performance monitoring.

## Interactions
1. The client sends a request to the Notification API.
2. The rate limiter checks if the client has exceeded their rate limit.
3. If the rate limit is not exceeded, the quota manager checks if the client has exceeded their monthly quota.
4. If the quota is not exceeded, the request is validated and forwarded to the appropriate messaging service via RabbitMQ.
5. The messaging service processes the request, sending the notification and logging the event.
6. A response is sent back to the client.
