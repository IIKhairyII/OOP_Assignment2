using OOP_Assignment2.Inheritance;
using OOP_Assignment2.Polymorphism;

namespace OOP_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructor Chaining
            Car car = new(15);
            Console.WriteLine("<================================>");
            Car car1 = new(15, 250);
            Console.WriteLine("<================================>");
            Car car2 = new(15, 180, "KIA");
            #endregion
            #region Inheritance
            Console.WriteLine("<================================>");
            Parent child = new Child(1, 2, 3);
            Console.WriteLine(child);
            Parent parent = new(1, 2);
            Console.WriteLine(parent);
            #endregion
            #region Polymorphism
            TypeA a = new();
            int res1 = a.Sum(5, 10);
            int res2 = a.Sum(5, 10, 50);

            Console.WriteLine("<================================>");
            Console.WriteLine($"res1 = {res1} || res2 = {res2}");
            a.PrintA();
            a.PrintB();
            Console.WriteLine("<================================>");
            TypeB b = new();
            b.PrintA();
            b.PrintB();
            #endregion
        }
    }
}