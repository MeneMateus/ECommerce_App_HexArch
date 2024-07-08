namespace ECommerceApp.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public required ICollection<OrderItem> OrderItems { get; set; }
    }
}