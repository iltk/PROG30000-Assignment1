using Assignment1_IlliaTkach.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_IlliaTkach.Controllers;

public class EquipmentController : Controller
{
    [Route("AllEquipment")]
    public IActionResult All()
    {
        ViewData["Title"] = "All Equipment Listing";
        return View(Repository.Equipment);
    }

    [Route("AvailableEquipment")]
    public IActionResult Available()
    {
        ViewData["Title"] = "Available Equipment";
        var availableEquipment = Repository.Equipment.Where(e => e.IsAvailable).ToList();
        return View("All", availableEquipment);
    }
}