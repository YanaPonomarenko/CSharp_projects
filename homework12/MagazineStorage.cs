using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace homework12
{
    public static class MagazineStorage
    {
        public static void SaveToFile(Magazine magazine, string filePath)
        {
            string json = JsonConvert.SerializeObject(magazine, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static Magazine LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Magazine>(json);
        }
    }
}
