using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechStocks.Models;

namespace TechStocks.Services
{
    public class StockDataStore : IStockDataStore
    {

        private static readonly List<Stock> stocks;

        // static constructor is used to initialize any static data, or to perform a particular action that needs performed once
        static StockDataStore()
        {
            stocks = new List<Stock>()
            {
                 new Stock { Id="0", Company="Microsoft", Symbol="MSFT", Url="https://www.marketwatch.com/investing/stock/msft"},
                 new Stock { Id="1", Company="Apple", Symbol="AAPL", Url="https://www.marketwatch.com/investing/stock/aapl"},
                 new Stock { Id="2", Company="Amazon", Symbol="AMZN", Url="https://www.marketwatch.com/investing/stock/amzn"},
                 new Stock { Id="3", Company="Alphabet", Symbol="GOOG", Url="https://www.marketwatch.com/investing/stock/goog"},
                 new Stock { Id="4", Company="Facebook", Symbol="FB", Url="https://www.marketwatch.com/investing/stock/fb"}
            };
        }

        // For Dep Injection
        public StockDataStore()
        {           
        }



        public async Task<Stock> AddStockAsync(Stock stock)
        {
            // throw new NotImplementedException();
            return new Stock();
        }

        public async Task<Stock> GetStockAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Stock>> GetStocksAsync()
        {
            return await Task.FromResult(stocks);
        }
    }
}
