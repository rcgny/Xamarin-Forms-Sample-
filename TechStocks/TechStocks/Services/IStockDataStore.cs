using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechStocks.Models;

namespace TechStocks.Services
{
   public interface IStockDataStore
    {
        Task<Stock> AddStockAsync(Stock stock);   
        Task<Stock> GetStockAsync(int id);
        Task<IList<Stock>> GetStocksAsync();  
    }
}
