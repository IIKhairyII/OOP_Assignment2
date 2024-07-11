namespace OOP_Assignment2
{
    public class Car
    {
        public Car(int id, int speed, string model)
        {
            Id = id;
            Speed = speed;
            Model = model;
            Console.WriteLine("Constructr 1");
        }
        public Car(int id, int speed) : this(id, speed, "BMW")
        {
            Console.WriteLine("Constructr 2");
        }
        public Car(int id) : this(id, 300, "Lambo")
        {
            Console.WriteLine("Constructr 3");
        }
        public int Id { get; set; }
        public int Speed { get; set; }
        public string? Model { get; set; }
    }
}
