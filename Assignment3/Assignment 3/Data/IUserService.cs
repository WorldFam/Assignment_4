using System.Threading.Tasks;
using Assignment_3.Models;

namespace Assignment_1.Data
{
    public interface IUserService
    {
        Task<User> ValidateLogin(string userName, string password);
    }
}