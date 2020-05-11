using System;

using TechStocks.Models;

namespace TechStocks.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Stock Stock { get; set; }
        public ItemDetailViewModel(Stock stock = null)
        {
            Title = stock?.Company;
            Stock = stock;
        }
    }
}
