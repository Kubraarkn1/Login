using MauiDelivery.Views;
using Microsoft.Maui.Controls;

namespace MauiDelivery
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
       
        }
    }
}
