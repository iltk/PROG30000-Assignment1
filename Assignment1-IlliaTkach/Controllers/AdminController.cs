using Assignment1_IlliaTkach.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_IlliaTkach.Controllers;

public class AdminController : Controller
{
    [Route("Requests")]
    public IActionResult Requests()
    {
        ViewData["Title"] = "Equipment Requests";
        return View(Repository.Requests);
    }
}