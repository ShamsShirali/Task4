using Microsoft.AspNetCore.Mvc;
using TASk.Models;

namespace TASk.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _markas;

        public HomeController()
        {
            _markas = new List<Marka>()
            {
                new Marka{Id=1,Name="Mercedes"},
                new Marka{Id=2,Name="BMW"},
            };
        }
        public IActionResult Index()
        {
            return View(_markas);
        }
        
    }
}
