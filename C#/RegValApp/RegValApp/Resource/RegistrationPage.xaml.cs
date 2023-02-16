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
using Microsoft.Win32;
using System.IO;

namespace RegValApp.Resource
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        User contextUser;
        public RegistrationPage( User user)
        {
            InitializeComponent();
            GenderCb.ItemsSource = App.valiullinEntities.Gender.ToList();
            RoleCb.ItemsSource = App.valiullinEntities.Role.ToList();
            contextUser = user;
            DataContext = contextUser;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = ""; 
            if (string.IsNullOrWhiteSpace(NameTb.Text))
            {
                errorMessage += "Имя не введено";
                return;
            }
            if(NameTb.Text.Length > 50) 
            {
                errorMessage += "Имя не может содержать более 50 символов";
                return;
            }
            if(RoleCb.SelectedItem == null)
            {
                errorMessage += "Выберите роль";
                return;
            }
            if(GenderCb.SelectedItem == null)
            {
                errorMessage += "Выберите пол";
                return;
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                errorMessage += "Логин не введен";
                return;
            }
            if (LoginTb.Text.Length > 50)
            {
                errorMessage += "Логин не может содержать более 50 символов";
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                errorMessage += "Пароль не введен";
                return;
            }
            if (PasswordTb.Text.Length > 50)
            {
                errorMessage += "Пароль не может содержать более 50 символов";
                return;
            }
            if (contextUser.id == 0)
            {
                App.valiullinEntities.User.Add(contextUser);
                MessageBox.Show("Учетная запись успешно создана");
            }
            App.valiullinEntities.SaveChanges();
            NavigationService.GoBack();
        }

        private void ProfilePicBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextUser.ProfilePicture = File.ReadAllBytes(dialog.FileName);
                App.valiullinEntities.SaveChanges();
                ProfileIMg.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
