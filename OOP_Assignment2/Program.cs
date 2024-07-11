using OOP_Assignment2.Inheritance;

namespace OOP_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new(15);
            Console.WriteLine("<================================>");
            Car car1 = new(15, 250);
            Console.WriteLine("<================================>");
            Car car2 = new(15, 180, "KIA");
            Console.WriteLine("<================================>");
            Parent child = new Child(1, 2, 3);
            Console.WriteLine(child);
            Parent parent = new (1, 2);
            Console.WriteLine(parent);

        }
    }
}