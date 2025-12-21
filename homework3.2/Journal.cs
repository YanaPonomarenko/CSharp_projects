using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._2
{
    internal class Journal
    {
        public string Title { get; set; }
        private int year;
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Journal(string t, int y, string d, string p, string e)
        {
            Title = t;
            Year = y;
            Description = d;
            Phone = p;
            Email = e;
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0) year = 0;
                else year = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"\nЖурнал: {Title}");
            Console.WriteLine($"Рік: {Year}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
