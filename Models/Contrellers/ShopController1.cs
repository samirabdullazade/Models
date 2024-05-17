using Microsoft.AspNetCore.Mvc;

namespace Models.Contrellers
{
    public class ShopController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
