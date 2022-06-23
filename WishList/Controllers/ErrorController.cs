using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
