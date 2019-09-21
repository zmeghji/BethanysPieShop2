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
    public partial class MasterDetailView : MasterDetailPage
    {
        public MasterDetailView()
        {
            InitializeComponent();
            masterView.NavigationListView.ItemSelected += (sender, args) =>
             {
                 if (args.SelectedItem is MasterNavigationItem item)
                 {
                     Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                     masterView.NavigationListView.SelectedItem = null;
                     IsPresented = false;
                 }
             };
        }
    }
}