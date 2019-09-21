using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }
        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Helpers.HomePageView());
        }
        private async void BasketViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Helpers.BasketView());
        }
        private async void PieOverviewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Helpers.PieOverview());
        }
        private async void ContactUsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Helpers.ContactUs());
        }
    }
}