using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Assignment_1.Data;
using Models;

namespace Assignment_2.Data.Impl
{
    public class CloudService : ICloudService
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;
        
        public CloudService() {
            client = new HttpClient();
        }
        public async Task<IList<Adult>> GetAdultAsync() {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adult");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        
        public async Task AddAdultAsync(Adult adult) {
            string todoAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/Adult", content);
        }
        
        public async Task RemoveAdultAsync(int adultId) {
            await client.DeleteAsync($"{uri}/Adult/{adultId}");
        }

        public async Task UpdateAdultAsync(Adult adult) {
            string todoAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Adult/{adult.Id}", content);
        }
        
        public async Task<Adult> GetAdultByIdAsync(int Id)
        {
            Task<string> stringAsync = client.GetStringAsync( $"{uri}/Adult/{Id}");
            string message = await stringAsync;
            Adult result = JsonSerializer.Deserialize<Adult>(message);
            return result; 
        }
        
    }
}