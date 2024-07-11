namespace OOP_Assignment2.Composition
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }

        public OrderItem(int id, string name, string description, Product product)
        {
            Id = id;
            Name = name;
            Description = description;
            Product = product;
        }
    }
}
