using System.Windows;
using WpfFluentValidationExample.Views;

namespace WpfFluentValidationExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var userView = new UserView();
            userView.Show();
        }
    }
}
