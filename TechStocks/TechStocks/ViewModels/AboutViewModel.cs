using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TechStocks.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/rcgny/Xamarin-Forms-Sample-/tree/master/TechStocks"));
        }

        public ICommand OpenWebCommand { get; }
    }
}