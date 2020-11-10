using System.Collections.Generic;
using System.Threading.Tasks;
using Models;


namespace Assignment_3_API.Data
{
    public interface ICloudService
    {
        Task<IList<Adult>> GetAdultAsync();
        Task<Adult>   AddAdultAsync(Adult todo);
        Task   RemoveAdultAsync(int todoId);
        Task<Adult>   UpdateAdultAsync(Adult todo);
        Task<Adult> GetAdultByIdAsync(int id);
    }
}