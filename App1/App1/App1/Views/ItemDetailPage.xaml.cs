using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1.Models;
using App1.ViewModels;
using Microsoft.AppCenter.Analytics;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            Analytics.TrackEvent("Evnet for ItemDetailPage");
            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };
            Analytics.TrackEvent("Evnet for ItemDetailPage");
            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}