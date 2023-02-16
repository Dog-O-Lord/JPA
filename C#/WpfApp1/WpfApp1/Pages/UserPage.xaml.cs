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
using WpfApp1.Model;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        List<UserClass> UserList = new List<UserClass>();
        public UserPage()
        {
            InitializeComponent();
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            SexComboBox.Items.Add("Other");
            //List<user> wqe = new List<user>();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            
            string name = NameTextBox.Text;
            if (String.IsNullOrWhiteSpace(name) == true) 
            {
                MessageBox.Show("Invalid name");
                return;
            }
            string sex = SexComboBox.Text;
            if(String.IsNullOrWhiteSpace(sex) == true)
            {
                MessageBox.Show("Sex is not chosen");
                return;
            }


            //string date = DPicker.SelectedDate;
            DateTime? birthDate = DatePicker.SelectedDate;
            if (birthDate.HasValue == false)
            {
                MessageBox.Show("Date is not chosen");
                return;
            }
            int Age = DateTime.Now.Year - birthDate.Value.Year;
            if (Age <= 18)
            {
                MessageBox.Show("Incorrect Age");
                return;
            }
            string password = PasswordTextbox.Text;
            if (String.IsNullOrWhiteSpace(password) == true )
            {
                MessageBox.Show("Password is not chosen");
                return;
            }
            UserClass UserObject = new UserClass(  name, sex, birthDate, password);
         
            UserList.Add(UserObject);
            DataGrid.ItemsSource = UserList.ToList();
        }
    }
}
