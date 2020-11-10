using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_1.Models;

namespace Assignment_1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}