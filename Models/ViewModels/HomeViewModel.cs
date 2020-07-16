using Models;
using System.Collections.Generic;

namespace BethanysPieShop.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}