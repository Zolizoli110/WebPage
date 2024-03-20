using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        IActionResult view = View();
        _logger.LogInformation($"Called: {view.ToString()}");
        return view;
    }

    public IActionResult Prices()
    {
        IActionResult view = View();
        _logger.LogInformation($"Called: {view.ToString()}");
        return view;
    }

    public IActionResult Galery()
    {
        IActionResult view = View();
        _logger.LogInformation($"Called: {view.ToString()}");
        return view;
    }
    public IActionResult Contact()
    {
        IActionResult view = View();
        _logger.LogInformation($"Called: {view.ToString()}");
        return view;
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}