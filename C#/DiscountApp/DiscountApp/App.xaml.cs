using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DiscountApp.DBModel;

namespace DiscountApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ValiullinDecorDBEntities DecorDB = new ValiullinDecorDBEntities();
        public static User LoggedUser;
    }
}
