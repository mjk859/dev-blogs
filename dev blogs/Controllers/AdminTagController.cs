using Microsoft.AspNetCore.Mvc;

namespace dev_blogs.Controllers
{
    public class AdminTagController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
