using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
using Task.PageModels;
using Xamarin.Forms;

namespace Task.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SfListView_SwipeEnded(object sender, Syncfusion.ListView.XForms.SwipeEndedEventArgs e)
        {
            var item = e.ItemData as Script;
            var mainPage = BindingContext as MainPageModel;

            mainPage?.DeleteScriptCommand.Execute(item);
            ScriptsListView.ResetSwipe();
        }
    }
}
