using Assignment1_IlliaTkach.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_IlliaTkach.Controllers;

public class RequestController : Controller
{
    
    [HttpGet]
    [Route("RequestForm")]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    [Route("RequestForm")]
    public IActionResult Create(Form form)
    {

        return View();
    }
}