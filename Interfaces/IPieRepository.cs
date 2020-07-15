using Models;
using System.Collections.Generic;

namespace BethanysPieShop.Interfaces
{
    public interface IPieRepository
    {
        public IEnumerable<Pie> AllPies { get; }
        public IEnumerable<Pie> PiesOfTheWeek { get;  }
        public Pie GetPieById(int Id)  ;
        
    }
}