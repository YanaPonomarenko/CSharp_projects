using System.Drawing;
using System.Linq.Expressions;

namespace Less_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Employee emp= new Employee();

            //    emp.Name = "Ivan";
            //    emp.Age = 20;
            //    emp.Salary = 1500;

            //    emp.Show();

            Point p1 = new Point(3, 5);
            Point p2 = new Point(2, 7);

            Point p3 = p1 + p2; 

            Console.WriteLine($"p1 = {p1}");      
            Console.WriteLine($"p2 = {p2}");       
            Console.WriteLine($"p3 = p1 + p2 = {p3}"); 
        }
    }
}
