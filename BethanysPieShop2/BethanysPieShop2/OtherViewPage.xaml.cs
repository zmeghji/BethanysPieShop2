using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OtherViewPage : ContentPage
    {
        public OtherViewPage()
        {
            InitializeComponent();
        }
        private async void MainStepper_OnValueChanged(object sender, ValueChangedEventArgs args)
        {
            ValueLabel.Text = Math.Round(args.NewValue).ToString(CultureInfo.InvariantCulture);
        }
    }
}