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
using AuthApp.Model;

namespace AuthApp.Pages
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
            var user = App.authEntities.User.FirstOrDefault(u => u.Login == LoginTb.Text && u.Password == PasswordTb.Text);
            if (user == null)
            {
                MessageBox.Show("No matching user");
                return;
            }
            if(user.RoleId == 1)
            {
                MessageBox.Show("Succesfull authorization");
                NavigationService.Navigate(new UserLVPage());
            }
            if(user.RoleId == 2)
            {
                MessageBox.Show("Succesfull authorization");
                NavigationService.Navigate(new UerListPage());
            }
            if(user.RoleId == 3)
            {
                MessageBox.Show("Succesfull authorization");
                NavigationService.Navigate(new EasterEggPage());
            }
         
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}
