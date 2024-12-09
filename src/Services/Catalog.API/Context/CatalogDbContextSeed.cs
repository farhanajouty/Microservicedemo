using Catalog.API.Interfaces.Manager;
using Catalog.API.Manager;
using Catalog.API.Models;

namespace Catalog.API.Context
{
    public class CatalogDbContextSeed
    {
        static ProductManager _productManager = new ProductManager();


        public static void Seed()
        {
            var product = _productManager.GetFirstOrDefault(c => true);

            if (product == null)
            {
                _productManager.Add(getPreConfiguredProducts());

            }
        }

        private static List<Product> getPreConfiguredProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "P001",
                    Name = "Wireless Mouse",
                    Description = "Ergonomic wireless mouse with adjustable DPI settings.",
                    Category = "Electronics",
                    Summary = "A comfortable and efficient wireless mouse.",
                    ImageFile = "wireless_mouse.jpg",
                    Price = 25.99m
                },
                new Product
                {
                    Id = "P002",
                    Name = "Gaming Keyboard",
                    Description = "Mechanical keyboard with RGB lighting and macro keys.",
                    Category = "Electronics",
                    Summary = "Perfect for gamers and professionals.",
                    ImageFile = "gaming_keyboard.jpg",
                    Price = 79.99m
                },
                new Product
                {
                    Id = "P003",
                    Name = "Noise Cancelling Headphones",
                    Description = "Over-ear headphones with active noise cancellation.",
                    Category = "Audio",
                    Summary = "Immerse yourself in high-quality sound.",
                    ImageFile = "headphones.jpg",
                    Price = 199.99m
                },
                new Product
                {
                    Id = "P004",
                    Name = "Smartphone Stand",
                    Description = "Adjustable stand for smartphones and tablets.",
                    Category = "Accessories",
                    Summary = "Keep your devices stable and secure.",
                    ImageFile = "smartphone_stand.jpg",
                    Price = 15.49m
                },
                new Product
                {
                    Id = "P005",
                    Name = "Portable Power Bank",
                    Description = "10000mAh power bank with fast charging capabilities.",
                    Category = "Accessories",
                    Summary = "Charge your devices on the go.",
                    ImageFile = "power_bank.jpg",
                    Price = 29.99m
                }
          };

        }
    }
}
