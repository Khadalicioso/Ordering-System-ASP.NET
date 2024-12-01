namespace IPT_OrderingSystem.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal Total => Items.Sum(i => i.Product.Price * i.Quantity);

        public void AddItem(Product product, int quantity)
        {
            var cartItem = Items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (cartItem == null)
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
            else
            {
                cartItem.Quantity += quantity;
            }
        }

        public void RemoveItem(int productId)
        {
            var cartItem = Items.FirstOrDefault(i => i.Product.ProductId == productId);
            if (cartItem != null)
            {
                Items.Remove(cartItem);
            }
        }

        public void UpdateItem(int productId, int quantity)
        {
            var cartItem = Items.FirstOrDefault(i => i.Product.ProductId == productId);
            if (cartItem != null)
            {
                if (quantity > 0)
                {
                    cartItem.Quantity = quantity;
                }
                else
                {
                    RemoveItem(productId);
                }
            }
        }

        public class CartItem
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
    }
}