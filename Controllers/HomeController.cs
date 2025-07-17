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
        return View();
    }

    public IActionResult LogIn(string email, string contrasena)
    {
        int id = BD.Login(email, contrasena);
        if(id == 0){
            return View("ErrorLogIn");
        }else{
            HttpContext.Session.SetString("idUser", id.ToString());
            ViewBag.Usuario=BD.GetUsuario(id);
            return View("Personal");
        }
    }

    public IActionResult DatoFamiliar(){
        int id = int.Parse(HttpContext.Session.GetString("idUser"));
        ViewBag.DatosFamiliares = BD.GetDatoFamiliar(id);
        return View("DatoFamiliar");
    }

    public IActionResult DatoInteres(){
        int id = int.Parse(HttpContext.Session.GetString("idUser"));
        ViewBag.DatosIntereses = BD.GetDatoInteres(id);
        return View("DatoInteres");
    }

    public IActionResult Volver(){
        int id = int.Parse(HttpContext.Session.GetString("idUser"));
        ViewBag.Usuario=BD.GetUsuario(id);
        return View("Personal");
    }

    public IActionResult LogOut(){
        HttpContext.Session.Remove("idUser");
        return View("LogOut");
    }
}
