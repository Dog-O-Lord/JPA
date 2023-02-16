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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        User contextUser;
        public RegPage()
        {
            InitializeComponent();
            var contextUser = new User();
            DataContext = contextUser;
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = null;
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                errorMessage += "Please, type your login";
            }
            if(LoginTb.Text.Length > 50)
            {
                errorMessage += "Invalid login";
            }
            var loginCheck = App.authEntities.User.FirstOrDefault( l => l.Login == LoginTb.Text);
            if(loginCheck != null)
            {
                errorMessage += "Login already exists";
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                errorMessage += "Please, type your password";
            }
            if (PasswordTb.Text.Length > 50)
            {
                errorMessage += "Invalid login";
            }
            if (string.IsNullOrWhiteSpace(ComparePasswordTb.Text))
            {
                errorMessage += "Please, type your password";
            }
            if (ComparePasswordTb.Text.Length > 50)
            {
                errorMessage += "Invalid login";
            }
            if(ComparePasswordTb.Text != PasswordTb.Text)
            {
                errorMessage +=("Ne popal\n");
            }
            if (errorMessage != null)
                MessageBox.Show(errorMessage);
            App.authEntities.User.Add(contextUser);
            App.authEntities.SaveChanges();
        }
    }
}
