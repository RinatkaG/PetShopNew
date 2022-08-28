using Microsoft.AspNetCore.Mvc;

namespace PetShopNew.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult CommentsIndex()
        {
            //if (ModelState.IsValid)
            //{
            //    return View(form);
            //}
            //else
            //{
            //    return View("FormView", form);
            //}v
            return View();
        }
    }
}
