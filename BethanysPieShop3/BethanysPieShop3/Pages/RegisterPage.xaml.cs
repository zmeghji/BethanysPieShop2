using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void  DatePicker_OnDateSelected(object sender, DateChangedEventArgs args)
        {
            if (args.NewDate != DateTime.Today)
            {
                await DisplayAlert("Alert","You weren't born today", "OK");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Registration Complete", "OK");
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(Username.Text) ||
                string.IsNullOrWhiteSpace(Password.Text)
                )
            {
                Register.IsEnabled = false;
            }
            else
            {
                Register.IsEnabled = true;
            }
        }
    }
}