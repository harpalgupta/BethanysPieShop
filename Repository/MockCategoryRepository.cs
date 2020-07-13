using BethanysPieShop.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category> {
            new Category{ Id=1,CategoryName="FruitPies",Description="all fruity Pies"},
            new Category{ Id=1,CategoryName="Cheese Cakes",Description="all cheese cakes"},
            new Category{ Id=1,CategoryName="Seasonal Pies",Description="all seasonal pies"},
            };
    }
}
