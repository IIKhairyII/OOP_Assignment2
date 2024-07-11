namespace OOP_Assignment2.Inheritance
{
    public class Parent
    {
        public Parent(int prop1, int prop2)
        {
            Prop1 = prop1;
            Prop2 = prop2;
            Console.WriteLine("Parent Constructor");
        }
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }

        public override string ToString()
        {
            return $"Parent: Prop1 = {Prop1}, Prop2 = {Prop2}";
        }
    }
}
