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
using RegValApp.Model;

namespace RegValApp.Resource
{
    /// <summary>
    /// Логика взаимодействия для WorkspacePage.xaml
    /// </summary>
    public partial class WorkspacePage : Page
    {
        public WorkspacePage()
        {
            InitializeComponent();
            GenderFilterCb.ItemsSource = App.valiullinEntities.Gender.ToList();
            RoleFilterCb.ItemsSource = App.valiullinEntities.Role.ToList();
        }

        private void GenderFilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void RoleFilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            var filtred = App.valiullinEntities.User.ToList();
            var selectedGender = GenderFilterCb.SelectedItem as Gender;
            var selectedRole = RoleFilterCb.SelectedItem as Role;
            if(string.IsNullOrWhiteSpace(SearchTb.Text) == false)
            {
                filtred = filtred.Where(n => n.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }
            if(selectedGender != null)
            {
                filtred = filtred.Where(g => g.GenderId == selectedGender.id).ToList();
            }
            if (selectedRole != null)
            {
                filtred = filtred.Where(g => g.RoleId == selectedRole.id).ToList();
            }
            UsserLV.ItemsSource = filtred;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
