using Microsoft.AspNetCore.Mvc;

namespace Projectarticles.Controllers
{
    
    public class ArticleController : Controller
    {
        [Route("/article")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
