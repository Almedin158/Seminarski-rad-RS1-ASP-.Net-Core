using Microsoft.AspNetCore.Mvc;

namespace PekaraKonjic.Controllers
{
    public class OnamaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}