using BethanysPieShop.Models;
using System;

namespace BethanysPieShop.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}