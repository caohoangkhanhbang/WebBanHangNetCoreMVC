using Microsoft.AspNetCore.Mvc;

namespace WebBanHangNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
