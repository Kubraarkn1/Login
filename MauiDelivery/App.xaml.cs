using MauiDelivery.Views;
using Microsoft.Maui.Controls;

namespace MauiDelivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
