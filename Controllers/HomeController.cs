using Microsoft.AspNetCore.Mvc;
using PetShopNew.Data;
using PetShopNew.Models;
using System.Diagnostics;

namespace PetShopNew.Controllers
{
    public class HomeController : Controller
    {
        readonly DBInfo _dBInfo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , DBInfo dBInfo)
        {
            _logger = logger;
            _dBInfo = dBInfo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalouge()
        {
            var animallsContext = _dBInfo.animals;
            //_dBInfo.Entry(Catalouge)
                //.Reference(a=>a.)
            return View(model: Catalouge);
        }
        public IActionResult Administraitor()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}