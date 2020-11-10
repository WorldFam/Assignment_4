using System.Collections.Generic;
using Models;


namespace Assignment_1.Data
{
    public interface IFileContext
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void UpdateAdult(Adult adult);

    }
}