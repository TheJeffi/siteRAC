using Microsoft.AspNetCore.Mvc;
using site.Data.Interfaces;
using site.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Controllers
{
    public class CarController : Controller
    {
        private readonly IAllCars _carRep;

        public CarController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Cars()
        {
            var carCars = new CarViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(carCars);
        }
    }
}
