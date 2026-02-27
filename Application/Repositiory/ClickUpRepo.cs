using Application.App_Code;
using Application.Services;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Application.Repositiory
{
    internal class ClickUpRepo : IClickUpService
    {
        private readonly HttpClient _httpClient;
        public ClickUpRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<string> GetTeamID(string emailID,string action)
        {
            string apiRl = ClickUpConfig.ClickUpApiBaseUrl+ action;
            var request = new HttpRequestMessage(HttpMethod.Get, apiRl);
            request.Headers.Add("Authorization", ClickUpConfig.Authorization_Key);
            var response = _httpClient.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(responseContent);
            }
            else
            {
                return null;
            }
                return null;
        }       
    }

}
 