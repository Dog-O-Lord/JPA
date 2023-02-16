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
using System.IO;
using Microsoft.Win32;
using DiscountApp.DBModel;

namespace DiscountApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Product contextProduct;
        public EditPage(Product product)
        {
            InitializeComponent();
            contextProduct = product;
            DataContext = contextProduct;
        }

        private void AddImgBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = App.DecorDB.Product.FirstOrDefault(p => p.id == contextProduct.id);
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                product.Image = File.ReadAllBytes(dialog.FileName);
                App.DecorDB.SaveChanges();
                ItemIMG.Source = new BitmapImage(new Uri(dialog.FileName));
            }
            App.DecorDB.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
