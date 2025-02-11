
// controller được gọi mặc định khi tao trang web lần đầu 

using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Privacy()
		{
			return View();
		}
        public IActionResult UnauthorizedResult()
        {
            return Unauthorized();
        }
    }
}
