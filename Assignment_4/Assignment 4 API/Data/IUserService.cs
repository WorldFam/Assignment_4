using System.Threading.Tasks;
using Assignment_3_API.Models;

namespace Assignnment_4_API.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}