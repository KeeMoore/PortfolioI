// index route 
using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;

public class PortfolioController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return ("This is my Index!");
    }

    [HttpGet("index/projects")]
    public string projects()
    {
        return ("These are my projects");
    }
    // Contacts Route
    [HttpGet]
    [Route("Index/Projects/Contacts")]
    public string Contacts()
    {
        return ("This is my Contact!");
    }
}

