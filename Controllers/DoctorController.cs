using FeverCheckControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeverCheckControl.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckTemperature(float temperature) 
        { 
            string message = TemperatureUtility.CheckFever(temperature);
            return Json(message);
        }
    }
}
