using System;
using System.Text.Json.Serialization;

namespace Assignment_3.Models
{
    public class User
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }

     
    }
    
    
}