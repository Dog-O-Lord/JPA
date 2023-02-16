using RegValApp.Model;
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

namespace RegValApp.Resource
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

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = App.valiullinEntities.User.FirstOrDefault(u => u.Login == LoginTb.Text);
            if(user == null)
            {
                MessageBox.Show("Нет такого пользователя, кх-тьфу");
                return;
            }
            if (user.Password != PasswordTb.Text) 
            {
                MessageBox.Show("Пароль неверен");
                return;
            }
            switch (user.RoleId)
            {
                case (1): NavigationService.Navigate(new WorkspacePage());
                    break;
                case (2):
                    NavigationService.Navigate(new WorkspacePage());
                    break;
                case (3):
                    NavigationService.Navigate(new WorkspacePage());
                    break;
            }
            App.loggedUser = user;
            NavigationService.Navigate(new WorkspacePage());
            
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage(new User())); 
        }
    }
}
