using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_1.Data;
using Models;

namespace Assignment_2.Data.Impl
{
    public class CloudService : ICloudService
    {
        private string uri = "http://dnp.metamate.me";
        private readonly HttpClient client;

        public CloudService() {
            client = new HttpClient();
        }
        public async Task<IList<Adult>> GetAdultAsync() {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        
        public async Task AddAdultAsync(Adult adult) {
            string todoSerialized = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(todoSerialized,
                Encoding.UTF8,
                "application/json");
            await client.PutAsync("http://dnp.metamate.me/Adults", content);
        }

        public async Task RemoveAdultAsync(int adultId) {
            await client.DeleteAsync($"{uri}/Adults/{adultId}");
        }

        public async Task UpdateAdultAsync(Adult adult) {
            string todoAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
           HttpResponseMessage responseMessage = await client.PatchAsync($"{uri}/Adults/{adult.Id}", content);
           Console.Write(responseMessage.ToString()); // Status Code: 405;
        }
        
        public async Task<Adult> GetAdultByIdAsync(int Id)
        {
            Task<string> stringAsync = client.GetStringAsync( $"{uri}/Adults/{Id}");
            string message = await stringAsync;
            Adult result = JsonSerializer.Deserialize<Adult>(message);
            return result; 
        }
    }
}