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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WorkFrame1.xaml
    /// </summary>
    public partial class WorkFrame1 : Page
    {
        public WorkFrame1()
        {
            InitializeComponent();
            SCBox.Items.Add("Male");
            SCBox.Items.Add("Female");
            SCBox.Items.Add("Other");
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string name = NTBox.Text;
            string sex = SCBox.Text;
            string date = DPicker.SelectedDate.ToString();
            string password = PTbox.Text;

            MessageBox.Show($"Full Name: {name}\nSex: {sex}\nBirthDate: {date}\nPassword: {password}");
        }
    }
}
