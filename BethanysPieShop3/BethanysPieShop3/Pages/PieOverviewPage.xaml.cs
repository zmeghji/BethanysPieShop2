using BethanysPieShop3.Models;
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
    public partial class PieOverviewPage : ContentPage
    {
        public PieOverviewPage()
        {
            InitializeComponent();
            PiesListView.ItemsSource = new List<Pie>
            {
                new Pie
                {
                    Name ="Apple",
                    Price=1.00
                },
                new Pie
                {
                    Name ="Cherry",
                    Price=2.00
                },
                new Pie
                {
                    Name ="Pumpkin",
                    Price=1.00
                }
            };
        }
    }
}