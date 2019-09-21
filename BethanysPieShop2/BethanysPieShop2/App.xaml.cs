using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ContentPageView();
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            //MainPage = new MasterDetailView();
            //MainPage = new CarouselPageView();
            //MainPage = new ModelPageView();
            //MainPage = new StackLayoutPage();
            //MainPage = new LabelPageView();
            //MainPage = new ImageViewPage();
            //MainPage = new ButtonViewPage();
            //MainPage = new SliderViewPage();
            //MainPage = new TimeAndDatePicker();
            //MainPage = new OtherViewPage();
            MainPage = new CustomEntryPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
