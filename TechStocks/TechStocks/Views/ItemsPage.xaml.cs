﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TechStocks.Models;
using TechStocks.Views;
using TechStocks.ViewModels;

namespace TechStocks.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem is Stock stock)
            {

                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(stock)));

                // Manually deselect item.
                ItemsListView.SelectedItem = null;
            }
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Stocks.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}