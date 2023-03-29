﻿using Microsoft.AspNetCore.Mvc;
using NSHongOanh.Models;
using System.Diagnostics;

namespace NSHongOanh.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}