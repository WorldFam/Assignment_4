using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using Assignment_1.Data;
using Assignment_1.Models;
using DNP_Assignment_1.Pages;
using Models;

namespace Assignment_1.Data
{
    public class FileContext : IFileContext
    {
        /*public IList<Family> Families { get; private set; }*/
        public static IList<Adult> adults { get; private set; }

        /*private readonly string familiesFile = "families.json";*/
        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            /*Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();*/
            adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
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
            // storing families
            /*string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }*/

            // storing persons
            string jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }
        
        public void AddAdult(Adult adult)
        {
            adult.Id = newId();
            adults.Add(adult);
            SaveChanges();
        }

        private static int lastId = 35;
        static int newId()
        {
            return Interlocked.Increment(ref lastId);
        }
    
        public void RemoveAdult(int todoId) {
            Adult toRemove = adults.First(t => t.Id == todoId);
            adults.Remove(toRemove);
            SaveChanges();
        }
        
        
        public void UpdateAdult(Adult adult)
        {
            adult.Update(adult);
            SaveChanges();
        }
        
    }
    }
