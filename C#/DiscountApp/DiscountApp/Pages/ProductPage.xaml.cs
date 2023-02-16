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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            ProductLV.ItemsSource = App.DecorDB.Product.ToList();
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            var filtred = App.DecorDB.Product.ToList();
            if(String.IsNullOrWhiteSpace(SearchTB.Text) == false)
            {
                filtred = filtred.Where(e => e.Name.ToLower().Contains(SearchTB.Text.ToLower())).ToList();
            }
            ProductLV.ItemsSource = filtred;
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new EditPage((sender as Button).DataContext as Product));
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ProductLV.SelectedItem as Product;
            if(selectedItem == null)
            {
                MessageBox.Show("No selected item");
                return;
            }
            NavigationService.Navigate(new EditPage(selectedItem));
        }
    }
}
