using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using uPPERaTIVE.Model;

namespace uPPERaTIVE
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ValiullinUpperativeEntities upperativeEntities = new ValiullinUpperativeEntities();
    }
}
