using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_1.Models;


namespace Assignment_1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private static IList<User> users;
        
        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    Password = "123456",
                    SecurityLevel = 2,
                    UserName = "Invader"
                },
                
                new User {
                    Password = "qwerty",
                    SecurityLevel = 2,
                    UserName = "Hacker"
                },
                
            }.ToList();      
            
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            User last = users.FirstOrDefault(user => user.Password.Equals(password));
            if (first == null || last == null)
            {
                throw new Exception( "User not found");
            }
            return first;
        }
    }
}