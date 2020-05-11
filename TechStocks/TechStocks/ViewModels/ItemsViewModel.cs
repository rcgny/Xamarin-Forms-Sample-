using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using TechStocks.Models;
using TechStocks.Views;

namespace TechStocks.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Stock> Stocks { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "               Tech Stocks";
            Stocks = new ObservableCollection<Stock>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }            

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Stocks.Clear();
                var stocks = await StockDataStore.GetStocksAsync();
                foreach (var stock in stocks)
                {
                    Stocks.Add(stock);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}