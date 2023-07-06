using Microsoft.AspNetCore.Mvc;
using Shop.Model;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;

        public CarsController(ICars cars)
        {
            _cars = cars ?? throw new ArgumentNullException(nameof(cars));
        }

        public ViewResult CarsView()
        {
            return View(_cars);
        }
    }
}