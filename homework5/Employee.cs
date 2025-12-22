using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}, {Age} years, ${Salary}");
        }

        public static Employee operator +(Employee emp, int amount)
        {
            emp.Salary += amount;
            return emp;
        }

        //для зменшення 
        public static Employee operator -(Employee emp, int amount)
        {
            emp.Salary -= amount;
            return emp;
        }

        //перевірка
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Salary == emp2.Salary;
        }

        //перевірка 
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Salary != emp2.Salary;
        }

        //порівняння 
        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }

        //порівняння 
        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }
    }
}
