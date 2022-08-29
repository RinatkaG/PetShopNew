using Microsoft.AspNetCore.Mvc;

namespace PetShopNew.Controllers
{
    public class TableACController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
