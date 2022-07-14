using Microsoft.AspNetCore.Mvc;
using ViltiesZiedasFilmai.Models;

namespace ViltiesZiedasFilmai.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmContext _filmContext;
        // GET: /<controller>/
        public IActionResult Index()
        {
         //   FilmContext context = HttpContext.RequestServices.GetService(typeof(ViltiesZiedasFilmai.Models.FilmContext)) as FilmContext;
            return View(_filmContext.GautiVisusFilmus());
        }
    }
}
