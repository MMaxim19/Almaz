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
    /// Логика взаимодействия для OrderAdd.xaml
    /// </summary>
    public partial class OrderAdd : Window
    {
        AlmazEnt almaz;
        public OrderAdd(AlmazEnt almaz, Изготовление изготовление)
        {
            InitializeComponent();
            this.almaz = almaz;
            this.DataContext= изготовление;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            almaz.SaveChanges();
            Close();
        }
    }
}
