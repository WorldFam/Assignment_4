using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace Assignment_3_API.Data.Impl
{
    public class CloudService : ICloudService
    {
        private string adultFile = "adults.json";
        private IList<Adult> adults;

        public CloudService() {
            adults = File.Exists(adultFile) ? ReadData<Adult>(adultFile) : new List<Adult>();
        }
        
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            string jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (StreamWriter outputFile = new StreamWriter(adultFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
        
        public async Task<IList<Adult>> GetAdultAsync() {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }
        
        public async Task<Adult> AddAdultAsync(Adult adult) {
            int max = adults.Max(todo => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            SaveChanges();
            return adult;
        }
        
        public async Task RemoveAdultAsync(int adultId) {
            Adult toRemove = adults.First(t => t.Id == adultId);
            adults.Remove(toRemove);
            SaveChanges();
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult)  {
            Adult toRemove = adults.First(t => t.Id == adult.Id);
            adults.Remove(toRemove);
            adults.Add(adult);
            SaveChanges(); // Doesn't save Adult for some reason (~48h)
            return adult; 
        }
        
        public async Task<Adult> GetAdultByIdAsync(int id)
        {
            for (int i = 0; i < adults.Count; i++)
            {
                if (adults[i].Id == id)
                {
                    return adults[i];
                }
            }
            return null;
        }
    }
}