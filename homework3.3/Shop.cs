using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._3
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Shop()
        {
        }

        public Shop(string n, string a, string d, string p, string e)
        {
            Name = n;
            Address = a;
            Description = d;
            Phone = p;
            Email = e;
        }

        public void Show()
        {
            Console.WriteLine($"\nМагазин: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
