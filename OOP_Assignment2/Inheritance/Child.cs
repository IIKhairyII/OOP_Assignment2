namespace OOP_Assignment2.Inheritance
{
    public class Child : Parent
    {
        public Child(int prop1, int prop2, int prop3) : base(prop1, prop2)
        {
            Prop3 = prop3;
            Console.WriteLine("Child Constructor");
        }
        public int Prop3 { get; set; }

        public override string ToString()
        {
            return $"Child: Prop1 = {Prop1}, Prop2 = {Prop2}, Prop3 = {Prop3}"; ;
        }
    }
}
