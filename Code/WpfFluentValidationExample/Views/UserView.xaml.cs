using System.Windows;
using WpfFluentValidationExample.ViewModels;

namespace WpfFluentValidationExample.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }
    }
}
