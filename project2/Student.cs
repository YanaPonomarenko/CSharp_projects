using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        private int[] grades;

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
            grades = new int[5];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < grades.Length)
                {
                    return grades[index];
                }
                else
                {
                    throw new Exception($"Incorrect index.Acceptable: 0-{grades.Length - 1}");
                }
            }
            set
            {
                if (index >= 0 && index < grades.Length)
                {
                    if (value >= 0 && value <= 10)
                    {
                        grades[index] = value;
                    }
                    else
                    {
                        throw new Exception($"Grades in range 0-10.Entered: {value}");
                    }
                }
                else
                {
                    throw new Exception($"Incorrect index Acceptable values: 0-{grades.Length - 1}");
                }
            }
        }

        public void Show()
        {
            Console.WriteLine($"Student: {Name}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine("Grades:");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {grades[i]}");
            }

            double average = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }
            average /= grades.Length;

            Console.WriteLine($"Average grade: {average:0.00}");
        }
    }
}