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
using uPPERaTIVE.Model;

namespace uPPERaTIVE.Pages
{
    /// <summary>
    /// Логика взаимодействия для OperatorMainPage.xaml
    /// </summary>
    public partial class OperatorMainPage : Page
    {
        public OperatorMainPage()
        {
            InitializeComponent();
            
        }

        private void Refresh()
        {
            IssueDG.ItemsSource = App.upperativeEntities.IssueAcceptance.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void AddIssue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IssueEditingPage(new IssueAcceptance()));
        }

        private void EditIssue_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = IssueDG.SelectedItem as IssueAcceptance;
            if(selectedItem == null)
            {
                MessageBox.Show("Choose DG item");
                return;
            }
            NavigationService.Navigate(new IssueEditingPage(selectedItem));
        }

        private void DeleteIssue_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = IssueDG.SelectedItem as IssueAcceptance;
            if (selectedItem == null)
            {
                MessageBox.Show("Choose DG item");
                return;
            }
            App.upperativeEntities.IssueAcceptance.Remove(selectedItem);
            App.upperativeEntities.SaveChanges();
            Refresh();
        }
    }
}
