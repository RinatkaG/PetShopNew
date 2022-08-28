using Microsoft.AspNetCore.Mvc;

namespace PetShopNew.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult CatalogueIndex()
        {
            return View();
        }
    }
}
