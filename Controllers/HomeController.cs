﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Agri_Energy.Models;

namespace Agri_Energy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Load Contact index
    public IActionResult Index()
    {
        return View();
    }

    //Load About page
    public IActionResult About()
    {
        return View();
    }

    //Load Contact page
    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}