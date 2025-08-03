using System;
using FreshMvvm;
using Task.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>(); ;
            var navigationPage = new FreshNavigationContainer(page);
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
