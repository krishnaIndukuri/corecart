﻿using corecart.Models;
using Microsoft.AspNetCore.Mvc;


namespace corecart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Restaurant obj = new Restaurant { Id = 201, Name = "Hyderabad House" };
            return View(obj);
        }
    }
    
}
