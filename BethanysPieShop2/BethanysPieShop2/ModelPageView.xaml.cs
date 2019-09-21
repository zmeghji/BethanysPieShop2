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
    public partial class ModelPageView : ContentPage
    {
        public ModelPageView()
        {
            InitializeComponent();
        }
        private async void Button_OnClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new LargeImagePageView());
        }
    }
}