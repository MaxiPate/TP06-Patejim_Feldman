using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Patejim_Feldman.Models;

namespace TP06_Patejim_Feldman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Object obj = new Object();
        HttpContext.Session.SetString("Objeto", Objeto.ObjectToString(obj));
        return View();
    }
    public IActionResult volver()
    {
        Object obj = Objeto.StringToObject<Object>(HttpContext.Session.GetString("Objeto"));
        HttpContext.Session.SetString("Objeto", Objeto.ObjectToString(obj));
        return View("Index");
    }
    public IActionResult Personal()
    {
        
        return View("Personal");
    }
}
