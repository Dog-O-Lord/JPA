using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RegValApp.Model;

namespace RegValApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NewAppValiullinEntities valiullinEntities = new NewAppValiullinEntities();
        public static User loggedUser = new User();
    }
}
