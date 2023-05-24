using CorporationXYZ.IntTests.Helper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CorporationXYZ.IntTests
{

        public class RateLimitingIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
        {
            private readonly HttpClient _httpClient;

            public RateLimitingIntegrationTests(WebApplicationFactory<Program> factory)
            {
                _httpClient = factory.CreateClient();
            }

            public void Dispose()
            {
                _httpClient.Dispose();
            }
        private async Task<string> GetJwtToken()
        {
            var loginRequest = new
            {
                username = "JaneDoe4",
                password = "Password2000"
            };

            var loginContent = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");
            var loginResponse = await _httpClient.PostAsync("/api/authentication/login", loginContent);
            loginResponse.EnsureSuccessStatusCode();

            var responseContent = await loginResponse.Content.ReadAsStringAsync();
            dynamic responseData = JsonConvert.DeserializeObject(responseContent);
            var token = responseData.accessToken;

            return token;
        }

        [Theory]
        [InlineData("/api/notify/sms")]
        public async Task SendSms_Endpoint_Should_Return_Success(string endpoint)
        {
            // Arrange
            var jwtToken = await GetJwtToken();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

            var smsRequest = new
            {
                UserId = "668814E8-1EED-40AE-052B-08DAD1FC717A",
                Recipient = "0781916866",
                Message = "sampleMessage"
            };
            var jsonContent = JsonConvert.SerializeObject(smsRequest);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // Act
            var response = await _httpClient.PostAsync(endpoint, content);

            // Assert
            // Assert
            if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                // The request was rate-limited
                response.StatusCode.Should().Be(HttpStatusCode.TooManyRequests);
            }
            else
            {
                // The request was not rate-limited
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        [Theory]
        [InlineData("/api/notify/sms")]
        public async Task RateLimit_Endpoints_Should_Respect_Configuration(string endpoint)
        {
            // Arrange
            var jwtToken = await GetJwtToken();
            var responses = new List<HttpResponseMessage>();

            for (int i = 0; i < 12; i++)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("Authorization", $"Bearer {jwtToken}");

                var payload = new
                {
                    UserId = "668814E8-1EED-40AE-052B-08DAD1FC717A",
                    Recipient = "0781916866",
                    Message = "sampleMessage"
                };

                var jsonContent = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                request.Content = content;

                // Act
                var response = await _httpClient.SendAsync(request);
                responses.Add(response);
                await Task.Delay(100); // Delay between consecutive requests
            }

            // Assert
            responses.Count(r => r.StatusCode == HttpStatusCode.OK).Should().Be(10); // Expect 10 successful requests
            responses.Count(r => r.StatusCode == HttpStatusCode.TooManyRequests).Should().Be(2); // Expect 2 rate-limited requests
        }







    }


}
