using site.Data.Interfaces;
using site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "быстрая и экологичная",
                        LongDesc = "экологичная машина для комфортных поездок по городу и трассе",
                        img = "/img/cars/teslaS.jpeg",
                        price = 8000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "BMW F90",
                        shortDesc = "мощный и красивый",
                        LongDesc = "хороший автомобиль для любителей классики",
                        img = "/img/cars/bmwM5.jpg",
                        price = 6000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Hyondai Solaris",
                        shortDesc = "простой и надежный",
                        LongDesc = "Универсальная машина для повседневных поездок в городе",
                        img = "/img/cars/Solaris.jpg",
                        price = 2000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "KIA Rio",
                        shortDesc = "маленький и удобный",
                        LongDesc = "Компактная машина,идеально подходящая под городские условия",
                        img = "/img/cars/kiaRio.jpg",
                        price = 2500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "KIA Sportage",
                        shortDesc = "стильный и мощный",
                        LongDesc = "Хорошее сочетание дизайна и мощи.Для города и бездорожья",
                        img = "/img/cars/KiaSportage.jpg",
                        price = 3500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
