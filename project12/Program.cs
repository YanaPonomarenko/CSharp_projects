using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace project12
{
    class Developer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public List<string> Languages { get; set; }
        public decimal Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var developers = new List<Developer>
        {
            new Developer { Name = "Kate", Age = 22, Country = "Ukraine", Languages = new List<string> {"C#", "Java"} },
            new Developer { Name = "Paul", Age = 25, Country = "France", Languages = new List<string> {"Java", "C++"} },
            new Developer { Name = "Zoya", Age = 19, Country = "USA", Languages = new List<string> {"C#", "Python"} },
            new Developer { Name = "Yuriy", Age = 30, Country = "France", Languages = new List<string> {"C#", "Java", "C++"} },
            new Developer { Name = "Stepan", Age = 27, Country = "Ukraine", Languages = new List<string> {"Python"} }
        };

            var q1 = from d in developers
                     where d.Country == "Ukraine" || d.Country == "France"
                     select d;

            var q1_ext = developers
                .Where(d => d.Country == "Ukraine" || d.Country == "France");

            var q2 = from d in developers
                     where d.Languages.Contains("Java") && d.Languages.Contains("C#")
                     select d;

            var q2_ext = developers
                .Where(d => d.Languages.Contains("Java") && d.Languages.Contains("C#"));

            var q3 = from d in developers
                     where !d.Languages.Contains("C++") && d.Age > 20
                     select d;

            var q3_ext = developers
                .Where(d => !d.Languages.Contains("C++") && d.Age > 20);

            var q4 = from d in developers
                     orderby d.Age descending
                     select d;

            var q4_ext = developers
                .OrderByDescending(d => d.Age);
            

            var q5 = (from d in developers
                      where d.Languages.Contains("C#")
                      select d).Count();

            var q5_ext = developers.Count(d => d.Languages.Contains("C#"));


            var q6 = (from d in developers
                      select d.Salary).Average();

            var q6_ext = developers.Average(d => d.Salary);

            Console.WriteLine("1) Розробники з Ukraine або France:");
            foreach (var d in q1) Console.WriteLine(d.Name);
            foreach (var d in q1_ext) Console.WriteLine(d.Name);

            Console.WriteLine("\n2) Розробники, які знають Java та C#:");
            foreach (var d in q2) Console.WriteLine(d.Name);
            foreach (var d in q2_ext) Console.WriteLine(d.Name);

            Console.WriteLine("\n3) Розробники, які не знають C++ і вік > 20:");
            foreach (var d in q3) Console.WriteLine(d.Name);
            foreach (var d in q3_ext) Console.WriteLine(d.Name);

            Console.WriteLine("\n4) Розробники відсортовані за віком спадання:");
            Console.WriteLine("LINQ оператори:");
            foreach (var d in q4) Console.WriteLine($"{d.Name}, Вік: {d.Age}");
            Console.WriteLine("Розширення LINQ:");
            foreach (var d in q4_ext) Console.WriteLine($"{d.Name}, Вік: {d.Age}");

            Console.WriteLine("\n5) Кількість розробників, які знають C#:");
            Console.WriteLine($"LINQ оператори: {q5}");
            Console.WriteLine($"Розширення LINQ: {q5_ext}");

            Console.WriteLine("\n6) Середній заробіток розробників:");
            Console.WriteLine($"LINQ оператори: {q6:F2}");
            Console.WriteLine($"Розширення LINQ: {q6_ext:F2}");
        }
    }
}

