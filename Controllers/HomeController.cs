﻿using Microsoft.AspNetCore.Mvc;
using PetShopNew.Data;
using PetShopNew.Models;
using System.Diagnostics;


namespace PetShopNew.Controllers
{
    public class HomeController : Controller
    {
        readonly DBInfo _dBInfo;
        
        //private readonly ILogger<HomeController> _logger;

        public HomeController(/*ILogger<HomeController> logger,*/ DBInfo dBInfo) :base()
        {
            //_logger = logger;
            _dBInfo = dBInfo;
        }

        public IActionResult Index()
        {
           

            return View(_dBInfo.animals);
        }

        public IActionResult Category()
        {
         
            return View(_dBInfo.animals);
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