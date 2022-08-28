using Microsoft.AspNetCore.Mvc;

namespace PetShopNew.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult AnimalsIndex()
        {
            //if (ModelState.IsValid)
            //{
            //    return View(form);
            //}
            //else
            //{
            //    return View("FormView", form);
            //}

            return View();
        }
    }
}
