using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcFirstSite.Models;

namespace mvcFirstSite.Controllers;

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

    // Sayfaya Route etmek için aşağıdakini yazıyoruz.
    [Route ("/shop")] 
    public IActionResult Shop()
    {
        return View();
    }

    [Route ("/blog")] 
    public IActionResult Blog()
    {
        return View();
    }

    [Route ("/contact")] 
    public IActionResult Contact()
    {
        return View();
    }

     [Route ("/login")] 
    public IActionResult Login()
    {
        return View();
    }
    
     [Route ("/register")] 
    public IActionResult Register()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
