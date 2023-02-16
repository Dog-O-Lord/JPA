using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiscountApp.DBModel;

namespace DiscountApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        User contextUser;
        public AuthPage()
        {
            InitializeComponent();
            var contextUser = new User();
            DataContext = contextUser;

        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            contextUser.Login = LoginTb.Text;
            var user = App.DecorDB.User.FirstOrDefault(u => u.Login == LoginTb.Text);
            if(user == null)
            {
                MessageBox.Show("Login is incorrect");
                return;
            }
            if(user.Password != PasswordTb.Text)
            {
                MessageBox.Show("Password is incorrect");
                return;
            }
            switch (user.RoleID)
            {
                case (1): NavigationService.Navigate(new ProductPage());
                    break;
                case (2):
                    NavigationService.Navigate(new RegistrationPAge());
                    break;
                case (3):
                    NavigationService.Navigate(new AuthPage());
                    break;
                case (4):
                    NavigationService.Navigate(new ProductPage());
                    break;
            }
            App.LoggedUser = user;
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPAge());
        }
    }
}
