using System;
using System.Linq;
using System.Threading.Tasks;
using Assignment_3_API.Models;
using Assignnment_4_API.DataAccess;


namespace Assignnment_4_API.Data.Impl
{
    public class SqliteUserService : IUserService
    {
        public AdultDbContext ctx;
        
        public SqliteUserService(AdultDbContext ctx)
        {
            this.ctx = ctx;
        }
        
        public async Task<User> ValidateUser(string userName, string passWord)
        {
            User user = ctx.Users.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(passWord));
            if (user != null)
            {
                return user;
            } 
            throw new Exception("User not found");
        }
    }
}