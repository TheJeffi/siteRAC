using site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.ViewModels
{
    public class CarViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}
