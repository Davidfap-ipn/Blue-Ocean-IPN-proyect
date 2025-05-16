using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogcitoPrueba.Models;

namespace BlogcitoPrueba.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult blog()
    {
        return View();
    }

    public IActionResult des_habitaciones()
    {
        return View();
    }

    public IActionResult catalogo()
    {
        return View();
    }

    public IActionResult destinos()
    {
        return View();
    }
    public IActionResult catalogo_habitaciones()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
