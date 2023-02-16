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
    /// Логика взаимодействия для UerListPage.xaml
    /// </summary>
    public partial class UerListPage : Page
    {
        public UerListPage()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            var filtred = App.authEntities.User.ToList();
            if(string.IsNullOrWhiteSpace(SearchTb.Text) == false)
            {
                filtred = filtred.Where(f => f.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }
            UserDG.ItemsSource = filtred;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            UserDG.Visibility = Visibility.Visible;
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
    }
}
