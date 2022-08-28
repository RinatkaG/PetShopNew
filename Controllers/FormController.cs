using Microsoft.AspNetCore.Mvc;
using PetShopNew.Models;

namespace PetShopNew.Controllers
{
    public class FormController : Controller
    {
        
        public IActionResult GetForm(Form form )
        {
            if(ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                return View("FormView", form);
            }
           
        }
    }
}
