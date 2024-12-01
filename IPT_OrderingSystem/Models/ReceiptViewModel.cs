namespace IPT_OrderingSystem.Models
{
    public class ReceiptViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ReceiptItem> ReceiptItems { get; set; }
        public decimal Total { get; set; }
    }

    public class ReceiptItem
    {
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
