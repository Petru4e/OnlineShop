using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductsRepository _productRepository;

        public CartController()
        {
            _productRepository = new ProductsRepository();
        }

        public IActionResult Index()
        {
            var cart = CartsRepository.TryGetByUserId(Constans.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = _productRepository.TryGetById(productId);
            CartsRepository.Add(product, Constans.UserId);
            return RedirectToAction("Index");
        }
    }
}
