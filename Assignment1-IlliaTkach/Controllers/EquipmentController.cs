using Microsoft.AspNetCore.Mvc;

namespace Assignment1_IlliaTkach.Controllers;

public class EquipmentController : Controller
{
    
    [Route("AllEquipment")]
    public IActionResult All()
    {
        ViewData["Title"] = "All Equipment Listing";

        return View("All");
    }
    
    [Route("AvailableEquipment")]
    public IActionResult Available()
    {
        ViewData["Title"] = "Available Equipment ";

        return View("All");
    }
}