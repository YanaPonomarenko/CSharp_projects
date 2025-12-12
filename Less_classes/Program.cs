namespace Less_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee emp= new Employee();

            emp.Name = "Ivan";
            emp.Age = 20;
            emp.Salary = 1500;

            emp.Show();
        }
    }
}
