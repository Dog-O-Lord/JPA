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
    /// Логика взаимодействия для RegistrationPAge.xaml
    /// </summary>
    public partial class RegistrationPAge : Page
    {
        User contextUser;
        public RegistrationPAge()
        {
            InitializeComponent();
            contextUser = new User();
            DataContext = contextUser;
            RoleCb.ItemsSource = App.DecorDB.Role.ToList();
        }


        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DecorDB.User.FirstOrDefault(u => u.Login == contextUser.Login);
            if(user != null)
            {
                MessageBox.Show("Zanyato");
                return;
            }

            App.DecorDB.User.Add(contextUser);
            App.DecorDB.SaveChanges();
            NavigationService.GoBack();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
