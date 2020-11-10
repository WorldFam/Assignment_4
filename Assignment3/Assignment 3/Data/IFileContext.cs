using System.Collections.Generic;
using System.Threading.Tasks;
using Models;


namespace Assignment_1.Data
{
    public interface ICloudService
    {
        Task<IList<Adult>> GetAdultAsync();
        Task   AddAdultAsync(Adult todo);
        Task   RemoveAdultAsync(int todoId);
        Task   UpdateAdultAsync(Adult todo);

        Task<Adult> GetAdultByIdAsync(int id);

    }
}