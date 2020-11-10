using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_3_API.Models;


namespace Assignment_3_API.Data.Impl
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

        public async Task<User> ValidateUser(string userName, string passWord)
        {
            User user = users.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(passWord));
            if (user != null)
            {
                return user;
            } 
            throw new Exception("User not found");
        }
         
    }
}