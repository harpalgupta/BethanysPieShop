using BethanysPieShop.Interfaces;
using BethanysPieShop.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories {
            get
            {
                return _appDbContext.Categories;
                
            }
        }

        private  AppDbContext _appDbContext { get; }
    }
}
