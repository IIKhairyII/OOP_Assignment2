namespace OOP_Assignment2.Polymorphism
{
    public class TypeA
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Sum(int a, int b) => a + b;
        public int Sum(int a, int b, int c) => a + b + c;
        public decimal Sum(decimal a, decimal b, decimal c) => a + b + c;
        public string Sum(string a, string b) => a + b;
        public virtual void PrintA() => Console.WriteLine("PrintA function in parent");
        public virtual void PrintB() => Console.WriteLine("PrintB function in parent");

    }
}
