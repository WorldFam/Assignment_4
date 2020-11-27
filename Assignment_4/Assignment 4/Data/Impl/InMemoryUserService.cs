using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_1.Data;
using Assignment_3.Models;


namespace Assignment_3.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        
        public async Task<User> ValidateLogin(string username, string password)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:5003/users?username={username}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser;

            } 
            throw new Exception("User not found");
        }
    }
}