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
    /// Логика взаимодействия для IssueEditingPage.xaml
    /// </summary>
    public partial class IssueEditingPage : Page
    {
        IssueAcceptance contextIssue;
       
        public IssueEditingPage(IssueAcceptance issue)
        {
            InitializeComponent();
            UserCB.ItemsSource = App.upperativeEntities.User.ToList();
            contextIssue = issue;
            DataContext = contextIssue;
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (contextIssue.UserId == null)
                error += "No USer\n";
            if (String.IsNullOrWhiteSpace(contextIssue.Issue) == true)
                error += "No Issue\n";
            if (error == null)
            {
                MessageBox.Show(error);
                return;
            }
            if (contextIssue.id == 0)
                App.upperativeEntities.IssueAcceptance.Add(contextIssue);
            App.upperativeEntities.SaveChanges();
            NavigationService.GoBack();
        }

    }
}
