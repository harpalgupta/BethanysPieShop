using BethanysPieShop.Interfaces;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Repository
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDbContext.Pies.Include(p => p.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);
            }
        }
        public Pie GetPieById(int Id)
        {
            return _appDbContext.Pies.Include(p => p.Category).First(p => p.Id == Id);

        }
    }
}
