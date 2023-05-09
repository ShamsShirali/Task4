using Microsoft.AspNetCore.Mvc;
using TASk.Models;

namespace TASk.Controllers
{
    public class ModelController : Controller
    {

        private readonly List<Modal> _modals;

        public ModelController()
        {
            _modals = new List<Modal>()
            {
                new Modal{Id=1,MarkaId=1,Name="RTHIJHLOFDIGOI"},
                new Modal{Id=2,MarkaId=1,Name="YTOKJHLOTKHTEJ"},
                new Modal{Id=3,MarkaId=1,Name="hdhdhdhhdhhd"}
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (!_modals.Exists(s => s.Id == id))
                {
                    return BadRequest();
                }
                return View(_modals.FindAll(s => s.MarkaId == id));
            }

            return View(_modals);
        }

        //if (id != null) return BadRequest();

        //Modal modals = _modals.Find(s => s.Id == id);

        //    if(modals == null) return NotFound();

        //    return View(_modals);
    }
}
