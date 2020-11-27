
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment_3_API.Models
{
    public class User
    {
        [JsonPropertyName("UserName"), Key]
        public string UserName { get; set; }
        [JsonPropertyName("Password")]
      public string Password { get; set; }
      [JsonPropertyName("SecurityLevel")]
      public int SecurityLevel { get; set; }
      
    }
}