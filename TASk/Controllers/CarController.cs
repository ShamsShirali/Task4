using Microsoft.AspNetCore.Mvc;
using TASk.Models;

namespace TASk.Controllers
{
    public class CarController : Controller
    {

        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new List<Car>()
            {
                new Car {Id=1,ModalId=1,Color="red",Year=1995},
                new Car {Id=2,ModalId=2,Color="grey",Year=2003},
                new Car {Id=3,ModalId=1,Color="yellow",Year=2000}
            };
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (!_cars.Exists(s => s.ModalId == id))
                {
                    return BadRequest();
                }
                return View(_cars.FindAll(s => s.ModalId == id));
            }

            return View(_cars);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return BadRequest();

            Car cars = _cars.Find(s => s.Id == id);

            if (cars == null) return NotFound();

            return View(cars);
        }
    }
}
