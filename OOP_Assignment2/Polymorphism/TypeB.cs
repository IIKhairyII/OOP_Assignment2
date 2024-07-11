namespace OOP_Assignment2.Polymorphism
{
    public class TypeB : TypeA
    {
        public override void PrintA() => Console.WriteLine("PrintA function in Child");
        public new void PrintB() => Console.WriteLine("Hiding PrintB function in Parent and implement new function in child");
    }
}
