namespace OOP_Assignment2.Composition
{
    public class Order
    {
        public int Id { get; set; }
        public string RefNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerMail { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderItem[] Items { get; set; }

        public Order(int id, string refNumber, OrderItem[] items)
        {
            Id = id;
            RefNumber = refNumber;
            Items = items;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
