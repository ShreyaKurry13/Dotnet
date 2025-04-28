using DemoApp.Tourism.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class HomeController(SiteModel model) : Controller
{
    public IActionResult Index()
    {
        var visitors = model.GetVisitors();
        return View(visitors);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string visitorId, int visitorRating)
    {
        model.AcceptVisit(visitorId, visitorRating);
        return RedirectToAction("Index");
    }

}