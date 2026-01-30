using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace project11
{
    internal class PersonsCMS
    {
        public string PathToFile { get; private set; }

        public PersonsCMS(string path)
        {
            PathToFile = path;
            if (!File.Exists(PathToFile))
                File.Create(PathToFile).Close();
        }

        public void AddPerson(Person person)
        {
            List<Person> people = GetAllPersons();
            people.Add(person);
            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            File.WriteAllText(PathToFile, json);
        }

        public List<Person> GetAllPersons()
        {
            string data = File.ReadAllText(PathToFile);
            if (string.IsNullOrWhiteSpace(data))
                return new List<Person>();

            return JsonConvert.DeserializeObject<List<Person>>(data) ?? new List<Person>();
        }

        public void ShowAllPersons()
        {
            List<Person> people = GetAllPersons();
            foreach (var person in people)
                Console.WriteLine(person);
        }

        public bool RemovePersonById(int id)
        {
            List<Person> people = GetAllPersons();
            Person? toRemove = people.Find(p => p.Id == id);
            if (toRemove == null)
                return false;

            people.Remove(toRemove);
            File.WriteAllText(PathToFile, JsonConvert.SerializeObject(people, Formatting.Indented));
            return true;
        }
    }
}
