namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Student student = new Student("Ivan", "3");

                Console.WriteLine("Enter 5 grades:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Grade {i + 1}: ");
                    student[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nStudent info:");
                student.Show();

                Console.ReadKey();
            }
        }
    }
}
