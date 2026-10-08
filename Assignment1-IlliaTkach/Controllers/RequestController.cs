using Assignment1_IlliaTkach.Models;
using Assignment1_IlliaTkach.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_IlliaTkach.Controllers;

public class RequestController : Controller
{
    
    [HttpGet]
    [Route("RequestForm")]
    public IActionResult RequestForm()
    {
        return View();
    }
    
    [HttpPost]
    [Route("RequestForm")]
    public IActionResult RequestForm(EquipmentRequest equipmentRequest)
    {
        if (ModelState.IsValid)
        {
            Repository.AddRequest(equipmentRequest);
            return View("Confirmation");
        }
        return View("RequestForm", equipmentRequest);

    }
}