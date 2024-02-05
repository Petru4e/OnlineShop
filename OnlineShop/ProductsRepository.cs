using OnlineShop.Models;

namespace OnlineShop
{
    public class ProductsRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product("Name1", 10, "Desc1", "/images/img1.jpg"),
            new Product("Name2", 20, "Desc2", "/images/img2.jpg"),
            new Product("Name3", 30, "Desc3", "/images/img3.jpg"),
            new Product("Name4", 40, "Desc4", "/images/img4.jpg"),
            new Product("Name5", 50, "Desc5", "/images/img5.jpg"),
            new Product("Name6", 60, "Desc6", "/images/img6.jpg"),
            new Product("Name7", 70, "Desc7", "/images/img1.jpg"),
            new Product("Name8", 80, "Desc8", "/images/img1.jpg")
        };
        public List<Product> GetAll()
        {  
            return _products; 
        }

        public Product? TryGetById(int id)
        {
          return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
