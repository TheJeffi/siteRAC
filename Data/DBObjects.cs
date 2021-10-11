using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "быстрая и экологичная",
                        LongDesc = "экологичная машина для комфортных поездок по городу и трассе",
                        img = "/img/cars/teslaS.jpeg",
                        price = 8000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["электромобили"]
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
                        Category = Categories["классические автомобили"]
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
                        Category = Categories["классические автомобили"]
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
                        Category = Categories["классические автомобили"]
                    }
                );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                    new Category{ categoryName = "электромобили", desc = "Современный вид транспорта"},
                    new Category{ categoryName = "классические автомобили", desc = "Машины с ДВС"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                }

                return category;
            }
        }
    }
}
