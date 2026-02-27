using System;
using System.Collections.Generic;
using System.Text;

namespace Application.App_Code
{
    internal class HttpHelper   
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = ClickUpConfig.ClickUpApiBaseUrl;
        private readonly string _authKey = ClickUpConfig.Authorization_Key;
        public HttpHelper(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetData(string endpoint) { 
        
            var request = new HttpRequestMessage(HttpMethod.Get, _baseUrl + endpoint);
            request.Headers.Add("Authorization", _authKey);
            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;
            }
            else
            {
                return null;
            }
        }


    }
}
