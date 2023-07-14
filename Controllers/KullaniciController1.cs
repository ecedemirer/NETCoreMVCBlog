using Microsoft.AspNetCore.Mvc;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
