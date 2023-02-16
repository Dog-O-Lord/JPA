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
    /// Логика взаимодействия для UserLVPage.xaml
    /// </summary>
    public partial class UserLVPage : Page
    {
        public UserLVPage()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            RoleFilterCB.ItemsSource = App.authEntities.Role.ToList();
            var filtred = App.authEntities.User.ToList();
            if (RoleFilterCB.SelectedItem != null)
            {
                filtred = filtred.Where(f => f.Role == RoleFilterCB.SelectedItem).ToList();
            }
            UserLV.ItemsSource = filtred;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void RoleFilterCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DropFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            RoleFilterCB.SelectedItem = null;
            Refresh();
        }

        private void AddNeUserBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditUserPage(new User()));
        }

        private void EditUserBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = UserLV.SelectedItem as User;
            NavigationService.Navigate(new EditUserPage(selectedItem));
        }

        private void DeleteUserBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = UserLV.SelectedItem as User;
            App.authEntities.User.Remove(selectedItem);
        }
    }
}
