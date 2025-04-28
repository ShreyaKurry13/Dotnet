using DemoApp.Tourism.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

[ApiController]
public class SiteController : ControllerBase
{
    [HttpGet("/api/site")]
    public IActionResult ReadVisitors(SiteModel model)
    {
        var visitors = model.GetVisitors();
        if(visitors.Any())
            return Ok(visitors);
        return NotFound();
    }

    public IActionResult WriteVisitor(Feedback input,SiteModel model)
    {
        model.AcceptVisit(input.Person,input.Rating);
        return Ok();
    }
}