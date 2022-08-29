using Microsoft.AspNetCore.Mvc;

namespace PetShopNew.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryIndex()
        {
            return View("Category");
        }
    }
}
