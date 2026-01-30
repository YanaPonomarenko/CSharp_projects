using System;

namespace project11
{
    internal class Program
    {
        private static string _path = "person.json";

        static void Main(string[] args)
        {
            PersonsCMS cms = new PersonsCMS(_path);

            cms.AddPerson(new Person("Ivan", 30));
            cms.AddPerson(new Person("Masha", 25));
            cms.AddPerson(new Person("Bob", 40));

            Console.WriteLine("All persons:");
            cms.ShowAllPersons();

            Console.WriteLine("\nRemoving person with Id = 23:");
            bool removed = cms.RemovePersonById(23);
            Console.WriteLine(removed ? "Removed" : "Not fond");

            Console.WriteLine("\nAfter removal:");
            cms.ShowAllPersons();

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
