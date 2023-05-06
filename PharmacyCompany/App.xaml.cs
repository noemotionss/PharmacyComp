using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PharmacyCompany.Model;

namespace PharmacyCompany
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PharmacyCompEntities1 DB = new PharmacyCompEntities1();
    }
}
