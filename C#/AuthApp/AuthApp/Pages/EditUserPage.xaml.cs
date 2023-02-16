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
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        User contextUser;
        public EditUserPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
