using paracommerce.Models;

namespace paracommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200.00M, StockQuantity = 10 },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 800.00M, StockQuantity = 25 },
                new Product { Id = 3, Name = "Desk Chair", Description = "Ergonomic office chair", Price = 150.00M, StockQuantity = 15 }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.StockQuantity = product.StockQuantity;
            }
        }

        public void DeleteProduct(int id)
        {
            _products.RemoveAll(p => p.Id == id);
        }
    }
}