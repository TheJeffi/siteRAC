using site.Data.Interfaces;
using site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "электромобили", desc = "Современный вид транспорта"},
                    new Category{ categoryName = "классические автомобили", desc = "Машины с ДВС"}
                };
            }
        }
    }
}
