using IPT_OrderingSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IPT_OrderingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Text.Json; // Add this for JSON serialization

namespace IPT_OrderingSystem.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext db;

        public CartController(ApplicationDbContext context)
        {
            db = context;
        }

        private Cart GetCart()
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = cartJson != null ? JsonSerializer.Deserialize<Cart>(cartJson) : new Cart();

            if (cart == null)
            {
                cart = new Cart();
                SaveCart(cart);
            }

            return cart;
        }

        private void SaveCart(Cart cart)
        {
            var cartJson = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("Cart", cartJson);
        }

        public ActionResult AddToCart(int productId, int quantity)
        {
            var cart = GetCart();
            var product = db.Products.Find(productId);

            if (product != null && quantity > 0)
            {
                cart.AddItem(product, quantity);
                SaveCart(cart);
            }

            return RedirectToAction("ViewCart");
        }

        public ActionResult RemoveFromCart(int productId)
        {
            var cart = GetCart();
            cart.RemoveItem(productId);
            SaveCart(cart);
            return RedirectToAction("ViewCart");
        }

        public ActionResult ViewCart()
        {
            var cart = GetCart();
            return View(cart);
        }

        public ActionResult Payment()
        {
            var cart = GetCart();

            if (cart.Items.Count == 0)
            {
                return RedirectToAction("ViewCart");
            }

            var receiptItems = cart.Items.Select(i =>
            {
                var product = db.Products.Find(i.Product.ProductId);
                return new ReceiptItem
                {
                    Quantity = i.Quantity,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    Amount = product.Price * i.Quantity
                };
            }).ToList();

            var receipt = new ReceiptViewModel
            {
                OrderId = new Random().Next(1000, 9999), // Random receipt number
                OrderDate = DateTime.Now,
                ReceiptItems = receiptItems,
                Total = cart.Total
            };

            return View(receipt);
        }

        public ActionResult UpdateCart(int productId, int quantity)
        {
            var cart = GetCart();
            var product = db.Products.Find(productId);

            if (product != null && quantity >= 0)
            {
                if (quantity > 0)
                {
                    cart.UpdateItem(productId, quantity);
                }
                else
                {
                    cart.RemoveItem(productId);
                }
                SaveCart(cart);
            }

            return RedirectToAction("ViewCart");
        }



    }
}