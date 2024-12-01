namespace IPT_OrderingSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
