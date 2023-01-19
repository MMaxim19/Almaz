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
using System.Windows.Shapes;

namespace Almaz
{
    /// <summary>
    /// Логика взаимодействия для MasterWin.xaml
    /// </summary>
    public partial class MasterWin : Window
    {
        AlmazEnt almaz;
        public MasterWin(AlmazEnt almaz, Ювелир ювелир)
        {
            InitializeComponent();
            this.almaz = almaz;
            this.DataContext = ювелир;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            almaz.SaveChanges();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
